using IdentityModel.Client;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.Diagnostics.CodeAnalysis;

namespace ImageGallery.Client.Controllers
{
    public class AuthenticationController(IHttpClientFactory httpClientFactory) : Controller
    {
        [Authorize]
        public async Task Logout()
        {
            var client = httpClientFactory.CreateClient("IDPClient");
            var discoveryDocumentResponse = await client.GetDiscoveryDocumentAsync();
            if(discoveryDocumentResponse.IsError)
            {
                throw new Exception(discoveryDocumentResponse.Error);
            }

            var accessTokenRevocationResponse = await client 
                   .RevokeTokenAsync(new ()
                   {
                       Address = discoveryDocumentResponse.RevocationEndpoint,
                       ClientId = "imagegalleryclient",
                       ClientSecret = "secret",
                       Token = await HttpContext.GetTokenAsync(OpenIdConnectParameterNames.AccessToken)
                   });

            if (accessTokenRevocationResponse.IsError)
            {
                throw new Exception(accessTokenRevocationResponse.Error);
            }

            var refreshTokenRevocationResponse = await client.RevokeTokenAsync(new()
            {
                Address = discoveryDocumentResponse.RevocationEndpoint,
                ClientId = "imagegalleryclient",
                ClientSecret = "secret",
                Token = await HttpContext.GetTokenAsync(OpenIdConnectParameterNames.AccessToken)
            });

            if (refreshTokenRevocationResponse.IsError)
            {
                throw new Exception(refreshTokenRevocationResponse.Error);
            }
            //Clears the local cookie
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignOutAsync(OpenIdConnectDefaults.AuthenticationScheme);
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
