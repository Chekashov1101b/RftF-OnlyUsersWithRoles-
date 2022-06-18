using Microsoft.AspNetCore.Identity;
using RF.Models;
using System.Linq;
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
            //Seed Default User
            var defaultUser = new ApplicationUser
            {
                UserName = "Odmen",
                Email = "superadmin@gmail.com",
                Nickname = "Odmen",
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
