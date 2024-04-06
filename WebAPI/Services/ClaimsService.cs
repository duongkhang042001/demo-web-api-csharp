using Application.Interfaces;
using Application.Utils;
using System.Security.Claims;

namespace WebAPI.Services
{
    public class ClaimsService : IClaimsService
    {
        public ClaimsService(IHttpContextAccessor httpContextAccessor)
        {
            // todo implementation to get the current userId
            var identity = httpContextAccessor.HttpContext?.User?.Identity as ClaimsIdentity;
            var extractedId = AuthenTools.GetCurrentAccountId(identity);
            GetCurrentUserId = string.IsNullOrEmpty(extractedId) ? Guid.Empty: Guid.Parse(extractedId);
        }

        public Guid GetCurrentUserId { get; }
    }
}
