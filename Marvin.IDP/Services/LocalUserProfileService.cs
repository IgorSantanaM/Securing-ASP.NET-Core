using Duende.IdentityServer.Extensions;
using Duende.IdentityServer.Models;
using Duende.IdentityServer.Services;
using System.Security.Claims;

namespace Marvin.IDP.Services
{
    public class LocalUserProfileService(ILocalUserService localUserService) : IProfileService
    {
        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            var subjectId = context.Subject.GetSubjectId();
            var claimsForUser = (await localUserService
                    .GetUserClaimsBySubjectAsync(subjectId))
                    .ToList();
            context.AddRequestedClaims(claimsForUser.Select(c => new Claim(c.Type, c.Value)).ToList());
        }

        public async Task IsActiveAsync(IsActiveContext context)
        {
            var subjectId = context.Subject.GetSubjectId();
            context.IsActive = await localUserService
                .IsUserActive(subjectId);
        }
    }
}
