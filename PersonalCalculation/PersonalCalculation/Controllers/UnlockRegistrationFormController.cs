using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalCalculation.Controllers
{
    public class UnlockRegistrationFormController : Controller
    {
        
        private string unlock = ConfigurationManager.AppSettings["UnlockRegForm"].ToString();

        [HttpPost]
        [Route("Controllers/UnlockRegistrationForm/Unlock")]
        public ActionResult Unlock(string secureCode)
        {
            if (secureCode == unlock)
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