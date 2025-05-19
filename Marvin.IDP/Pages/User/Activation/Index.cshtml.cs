using Marvin.IDP.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Marvin.IDP.Pages.User.Activation
{
    [SecurityHeaders]
    [AllowAnonymous]
    public class IndexModel(ILocalUserService localUserService) : PageModel
    {
        public InputModel Input { get; set; } = new();

        public async Task<IActionResult> OnGet(string securityCode)
        {
            if (await localUserService.ActivateUserAsync(securityCode))
                Input.Message = "Your account was successfully activated. " +
                    "Navigate to your client application to log in.";
            else
                Input.Message = "Your account couldn't be activated, " +
                    "please contact your administrato";

            await localUserService.SaveChangesAsync();

            return Page();
        }
    }
}
