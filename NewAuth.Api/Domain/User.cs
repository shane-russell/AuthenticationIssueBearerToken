using Microsoft.AspNetCore.Identity;

namespace NewAuth.Api.Domain
{
    public class User : IdentityUser<int>
    {
        public string CustomUserField { get; set; }
    }
}