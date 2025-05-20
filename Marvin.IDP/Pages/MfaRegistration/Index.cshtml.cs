using Marvin.IDP.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography;
using System.Text;

namespace Marvin.IDP.Pages.MfaRegistration
{
    [SecurityHeaders]
    [Authorize]
    public class IndexModel(ILocalUserService localUserService) : PageModel
    {
        private readonly char[] chars =
                        "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
        public void OnGet()
        {
            var tokenData = RandomNumberGenerator.GetBytes(64);

            var result = new StringBuilder(16);
            for(int i = 0; i < 16; i++)
            {
                var rnd = BitConverter
            }
        }
    }
}
