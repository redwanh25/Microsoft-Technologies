using Software_Company_WebApplication.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Software_Company_WebApplication.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            PersonBuisnessLayer personBuisnessLayer = new PersonBuisnessLayer();
            List<PersonMessage> list = personBuisnessLayer.personsIndex.ToList();
            return View(list);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            PersonBuisnessLayer personBuisnessLayer = new PersonBuisnessLayer();
            PersonMessage person = personBuisnessLayer.personsDetails.Single(per => per.Id == id);
            return View(person);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            PersonBuisnessLayer personBuisnessLayer = new PersonBuisnessLayer();
            personBuisnessLayer.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
    }
}