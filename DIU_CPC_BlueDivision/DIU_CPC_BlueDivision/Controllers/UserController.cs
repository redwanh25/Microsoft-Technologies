using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DIU_CPC_BlueDivision.Controllers
{
    public class UserController : Controller
    {
        public ActionResult ManageAccount(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                string page = "~/ForgetPasswordHTML/" + id + ".html";
                //string page = "~/ForgetPasswordFeature/Html/" + id + ".html";
                return new FilePathResult(page, "text/html");
            }
            return View("~/Views/Home/Index.cshtml");
        }
    }
}