using Microsoft.AspNetCore.Identity;

namespace JWTToken.WebApi.CustomIdentity
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
