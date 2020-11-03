using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using RoleBasedProject.Models;

[assembly: OwinStartupAttribute(typeof(RoleBasedProject.Startup))]
namespace RoleBasedProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateUserAndRoles();
        }
        public void CreateUserAndRoles()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if (!roleManager.RoleExists("SuperAdmin"))
            {
                //create super admin role
                var role = new IdentityRole("SuperAdmin");
                roleManager.Create(role);


                //create default user
                var user = new ApplicationUser();
                user.UserName = "test@gmail.com";
                user.Email = "test@gmail.com";
                string pwd = "000000";

                var newuser = userManager.Create(user, pwd);
                if (newuser.Succeeded)
                {
                    userManager.AddToRole(user.Id, "SuperAdmin");
                }

            }
        }
    }
}
