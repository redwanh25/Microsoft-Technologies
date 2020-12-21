using AutoCompleteTextbox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoCompleteTextbox.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult GetSearchValue(string search)
        {
            MVC_DatabaseEntities db = new MVC_DatabaseEntities();
            List<tblEmployee> allsearch = db.tblEmployees.Where(x => x.Name.Contains(search)).Select(x => new tblEmployee
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
            return new JsonResult { Data = allsearch, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}