using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DIU_CPC_BlueDivision.Controllers
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
            ViewBag.Title = "View1";
            return View();
        }

        public ActionResult View2()
        {
            ViewBag.Title = "View2";
            return View();
        }
    }
}
