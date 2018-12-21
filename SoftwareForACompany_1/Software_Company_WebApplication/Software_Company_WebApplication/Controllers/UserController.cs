using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Software_Company_WebApplication.Controllers
{
    public class UserController : Controller
    {

        public ActionResult ManageAccount(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                string page = "~/HTML/" + id + ".html";
                return new FilePathResult(page, "text/html");
            }
            return new FilePathResult("~/html/login.html", "text/html");
        }
    }
}