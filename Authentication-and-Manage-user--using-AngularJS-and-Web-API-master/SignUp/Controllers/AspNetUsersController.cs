using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SignUp.Models;
using System.Threading.Tasks;

namespace SignUp.Controllers
{
    //[Authorize]
    public class AspNetUsersController : ApiController
    {
        private ApplicationDbContext Context = new ApplicationDbContext();

        public IHttpActionResult Get()
        {
            var retval = Context.Users.Select(x => new { Id = x.Id, Email = x.Email, PhoneNumber = x.PhoneNumber });

            return Ok(retval);
        }

        public async Task<IHttpActionResult> Delete(string Id)
        {
            var userStore = new UserStore<ApplicationUser>(Context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            var user = Context.Users.Find(Id);

            var result = await userManager.DeleteAsync(user);

            return Ok();
        }
    }
}
