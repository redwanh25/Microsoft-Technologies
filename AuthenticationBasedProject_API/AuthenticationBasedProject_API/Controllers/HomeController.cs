using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthenticationBasedProject_API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult View1()
        {
            ViewBag.Message = "View1";

            return View();
        }
        public ActionResult View2()
        {
            ViewBag.Message = "View2";

            return View();
        }
    }
}
