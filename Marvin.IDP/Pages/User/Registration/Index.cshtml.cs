using Duende.IdentityServer.Services;
using IdentityModel;
using Marvin.IDP.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Marvin.IDP.Pages.User.Registration
{
    [AllowAnonymous]
    [SecurityHeaders]
    public class IndexModel : PageModel
    {
        private readonly ILocalUserService _localUserService;
        private readonly IIdentityServerInteractionService _interaction;


        public IndexModel(ILocalUserService localUserService, IIdentityServerInteractionService interaction)
        {
            _localUserService = localUserService;
            _interaction = interaction;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public void OnGet()
        {
        }

        private void BuildModel(string returnUrl)
        {
            Input = new InputModel
            {
                ReturnUrl = returnUrl,
            };
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                BuildModel(Input.ReturnUrl);
                return Page();
            }
        }
    }
}
