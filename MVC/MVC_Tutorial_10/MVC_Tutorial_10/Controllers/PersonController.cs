using MVC_Tutorial_10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Tutorial_10.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult P_Name(int departmentID)
        {
            PersonContext personContext = new PersonContext();
            List<Person> person = personContext.Persons.Where(per => per.DepartmentID == departmentID).ToList();
            return View(person);
        }
        public ActionResult P_Details(int id)
        {
            PersonContext personContext = new PersonContext();
            Person person = personContext.Persons.Single(per => per.PersonID == id);
            return View(person);
        }
    }
}