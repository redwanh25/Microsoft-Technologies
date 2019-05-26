using Ajax_based_WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ajax_based_WebApplication.Controllers
{
    public class StudentController : Controller
    {
        StudentTable_DBEntities db = new StudentTable_DBEntities();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult All()
        {
            List<StudentTable> list = db.StudentTables.ToList();
            return PartialView("studentTable", list);
        }

        public PartialViewResult Top3()
        {
            List<StudentTable> list = db.StudentTables.OrderByDescending(per => per.TotalMark).Take(3).ToList();
            return PartialView("studentTable", list);
        }

        public PartialViewResult Bottom3()
        {
            List<StudentTable> list = db.StudentTables.OrderBy(per => per.TotalMark).Take(3).ToList();
            return PartialView("studentTable", list);
        }
    }
}