using Microsoft.AspNetCore.Identity;

namespace NewAuth.Api.Domain
{
    public class Role : IdentityRole<int>
    {
        public const string RoleOne = "RoleOne";
        public const string RoleTwo = "RoleTwo";
    }
}