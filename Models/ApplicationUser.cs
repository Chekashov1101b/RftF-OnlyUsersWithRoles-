using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
//using System.Security.Claims;
//using System.Threading.Tasks;

namespace RF.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Nickname { get; set; }
        public byte[] ProfilePicture { get; set; }
        /*public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            userIdentity.AddClaim(new Claim("Nickname", Nickname));
            return userIdentity;
        }
        */
    }
}
