using System;

namespace JWTToken.WebApi.CustomIdentity
{
    public class ToknUser
    {
        public Guid Id { get; set; }
        public string IdentityId { get; set; }
        public AppUser Identity { get; set; }  // navigation property
    }
}
