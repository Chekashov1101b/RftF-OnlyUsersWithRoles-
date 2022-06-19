using Microsoft.AspNetCore.Identity;
using RF.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RF.Data
{
    public class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Models.Enums.Roles.roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Models.Enums.Roles.roles.Moderator.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Models.Enums.Roles.roles.User.ToString()));
        }
        public static async Task SeedAdminAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            string Pic = "0xFFD8FFE000104A46494600010100000100010000FFDB008400050304020202020202020202020607020807070707030202090205030606050305050816100B07080E0905060D150D0E11111F1313070B161816121810121312010505050706070508080512080508121212121212121212121212121212121212121212121212";
            //Seed Default User
            var defaultUser = new ApplicationUser
            {
                UserName = "Odmen",
                Email = "superadmin@gmail.com",
                Nickname = "Odmen",
                ProfilePicture = Encoding.UTF8.GetBytes(Pic),
                EmailConfirmed = true,
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "123Pa$$word");
                    await userManager.AddToRoleAsync(defaultUser, Models.Enums.Roles.roles.Admin.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Models.Enums.Roles.roles.Moderator.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Models.Enums.Roles.roles.User.ToString());
                }

            }
        }
    }
}
