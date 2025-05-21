using Duende.IdentityServer;
using Marvin.IDP.Areas.Identity.Data;
using Marvin.IDP.Data;
using Marvin.IDP.DbContexts;
using Marvin.IDP.Entities;
using Marvin.IDP.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace Marvin.IDP;

internal static class HostingExtensions
{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<IISOptions>(iis =>
        {
            iis.AuthenticationDisplayName = "Windows";
            iis.AutomaticAuthentication = false;
        });

        builder.Services.Configure<IISServerOptions>(iis =>
        {
            iis.AuthenticationDisplayName = "Windows";
            iis.AutomaticAuthentication = false;
        });

        // uncomment if you want to add a UI
        builder.Services.AddRazorPages();

        var connectionString = builder.Configuration.GetConnectionString("MarvinIDPContextConnection") ?? throw new InvalidOperationException("Connection string 'MarvinIDPContextConnection' not found.");

        builder.Services.AddDbContext<MarvinIDPContext>(options => options.UseSqlite(connectionString));

        builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<MarvinIDPContext>();

        builder.Services.AddScoped<ILocalUserService, LocalUserService>();
        builder.Services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();

        builder.Services.AddDbContext<IdentityDbContext>(options =>
        {
            options.UseSqlite(
                builder.Configuration
                .GetConnectionString("MarvinIdentityDBConnectionString"));
        });

        builder.Services.AddIdentityServer(options =>
            {
                // https://docs.duendesoftware.com/identityserver/v6/fundamentals/resources/api_scopes#authorization-based-on-scopes
                options.EmitStaticAudienceClaim = true;
            })
            .AddProfileService<LocalUserProfileService>()
            .AddInMemoryIdentityResources(Config.IdentityResources)
            .AddInMemoryApiScopes(Config.ApiScopes)
            .AddInMemoryApiResources(Config.ApiResources)
            .AddInMemoryClients(Config.Clients)
            .AddAspNetIdentity<ApplicationUser>();

        builder.Services
            .AddAuthentication()
            .AddOpenIdConnect("AAD", "Azure Active Directory", options =>
            {
                options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
                options.Authority = "AZURE AD ISSUER";
                options.ClientId = "ADD CLIENTID";
                options.ClientSecret = "ADD CLIENTSECRET";
                options.ResponseType = "code";
                options.CallbackPath = new PathString("/signin-aad/");
                options.SignedOutCallbackPath = new PathString("/signout-aad/");
                options.Scope.Add("email");
                options.Scope.Add("offline_access");
                options.SaveTokens = true;
            });

        builder.Services.AddAuthentication().AddFacebook(
               "Facebook",
               options =>
               {
                   options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
                   options.AppId = "FACEBOOKID";
                   options.AppSecret = "FACEBOOK SECRET";
               });



        return builder.Build();
    }
    
    public static WebApplication ConfigurePipeline(this WebApplication app)
    { 
        app.UseSerilogRequestLogging();
    
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        // uncomment if you want to add a UI
        app.UseStaticFiles();
        //app.UseRouting();
            
        app.UseIdentityServer();

        // uncomment if you want to add a UI
        app.UseAuthorization();
        app.MapRazorPages().RequireAuthorization();

        return app;
    }
}
