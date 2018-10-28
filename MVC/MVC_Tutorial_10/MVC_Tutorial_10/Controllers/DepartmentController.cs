using MVC_Tutorial_10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC_Tutorial_10.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            PersonContext personContext = new PersonContext();
            List<Department> department = personContext.Departments.ToList();
            return View(department);
        }
    }
}