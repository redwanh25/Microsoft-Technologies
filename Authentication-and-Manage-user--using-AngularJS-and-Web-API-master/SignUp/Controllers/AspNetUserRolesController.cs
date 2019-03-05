using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SignUp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SignUp.Controllers
{
    [Authorize]
    public class AspNetUserRolesController : ApiController
    {
        private ApplicationDbContext Context = new ApplicationDbContext();

        [HttpGet]
        [Route("api/Users/GetAll")]

        public IHttpActionResult GetAllUsers()
        {
            var retval = Context.Users.Select(x => new
                        { Id = x.Id, Email = x.Email,PhoneNumber = x.PhoneNumber, Roles = x.Roles });

            return Ok(retval);
        }

        [HttpGet]
        [Route("api/Roles/GetAll")]
        public IHttpActionResult GetAllRoles()
        {
            var retval = Context.Roles.ToList();

            return Ok(retval);
        }

        public async Task<IHttpActionResult> Post(string userId , [FromBody]List<string> roleIds)
        {
            var userStore = new UserStore<ApplicationUser>(Context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            var retval = await userManager.GetRolesAsync(userId);

            foreach(string role in retval)
            {
                await userManager.RemoveFromRolesAsync(userId, role);
            }

            var roles = Context.Roles.Where(x => roleIds.Contains(x.Id)).ToList();

            foreach (var role in roles)
            {
                await userManager.AddToRoleAsync(userId, role.Name);
            }

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
