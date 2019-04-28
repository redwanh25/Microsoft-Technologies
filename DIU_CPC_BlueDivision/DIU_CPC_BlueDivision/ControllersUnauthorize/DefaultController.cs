using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DIU_CPC_BlueDivision.ControllersUnauthorize
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            ViewBag.redwan = "redwan";
            return View();
        }
    }
}