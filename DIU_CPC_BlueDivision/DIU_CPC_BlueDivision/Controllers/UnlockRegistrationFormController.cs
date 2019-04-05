using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DIU_CPC_BlueDivision.Controllers
{
    public class UnlockRegistrationFormController : Controller
    {

        [HttpPost]
        [Route("Controllers/UnlockRegistrationForm/Unlock")]
        public ActionResult Unlock(string secureCode)
        {
            if (secureCode == "1234_U")
            {
                return Json(new { status = "Success" });
            }
            else
            {
                return Json(new { status = "error" });
            }
        }

        [NonAction] [HttpPost]
        [Route("Controllers/UnlockRegistrationForm/UnlockReg")]
        public ActionResult UnlockReg(string secureCode)
        {
            if (secureCode == "1234_U1")
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