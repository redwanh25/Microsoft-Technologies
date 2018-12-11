using MVC_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class EmployeeController : Controller
    {
        //GET: Employee
        //public ActionResult Details()
        //{
        //    Employee employee = new Employee()
        //    {
        //        EmployeeId = 101,
        //        Name = "Redwan",
        //        Gender = "Male",
        //        City = "London"
        //    };
        //    return View(employee);
        //}

        public ActionResult AddImage()
        {
            Brand b1 = new Brand();
            return View(b1);
        }
        [HttpPost]
        public ActionResult AddImage(Brand model, HttpPostedFileBase image1)
        {
            MVC_Demo_DatabaseEntities db = new MVC_Demo_DatabaseEntities();
            if(image1 != null)
            {
                model.BrandImage = new byte[image1.ContentLength];
                image1.InputStream.Read(model.BrandImage, 0, image1.ContentLength);
            }
            db.Brands.Add(model);
            db.SaveChanges();
            return View(model);
        }

        public ActionResult Index()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employees = employeeContext.Employees.ToList();
            return View(employees);
        }

        public ActionResult Details(int id)
        {
            EmployeeContext employeeContex = new EmployeeContext();
            Employee employee = employeeContex.Employees.Single(emp => emp.EmployeeId == id);
            return View(employee);
        }

    }
}