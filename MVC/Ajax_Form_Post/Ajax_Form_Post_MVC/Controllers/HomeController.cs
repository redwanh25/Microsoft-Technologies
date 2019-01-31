using Ajax_Form_Post_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ajax_Form_Post_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AjaxMethod(PersonModel person)
        {
            int personId = person.PersonId;
            string name = person.Name;
            string gender = person.Gender;
            string city = person.City;
            System.Threading.Thread.Sleep(1000);
            return Json(person);
        }
    }
}