using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Software_Company_WebApplication.Controllers
{
    public class UnlockRegistrationController : Controller
    {
        [HttpPost]
        [Route("Controllers/UnlockRegistration/Unlock")]
        public ActionResult Unlock(string secureCode)
        {
            if (secureCode == "1234_U1" || secureCode == "1234_U2")
            {
                return Json(new { status = "Success" });
            }
            else
            {
                return Json(new { status = "error" });
            }
        }
    }
}