using AngularJS_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularJS_Practice.Controllers
{
    public class ExtraController : Controller
    {
        // GET: Extra
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string text, List<ExtraClass> list)
        {

            return Json(new { data = text });
        }
    }
}