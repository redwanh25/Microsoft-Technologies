using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace MVC_BusinessObjectAsModel.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeBuisnessLayer employeeBuisnessLayer = new EmployeeBuisnessLayer();
            List<Employee> emps = employeeBuisnessLayer.employees.ToList();
            return View(emps);
        }

        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Create(FormCollection formCollection)
        //{

        //    Employee employee = new Employee();
        //    employee.Name = formCollection["Name"];
        //    employee.Gender = formCollection["Gender"];
        //    employee.City = formCollection["City"];
        //    employee.DateOfBirth = Convert.ToDateTime(formCollection["DateOfBirth"]);

        //    EmployeeBuisnessLayer employeeBuisnessLayer = new EmployeeBuisnessLayer();
        //    employeeBuisnessLayer.AddEmployee(employee);
        //    return RedirectToAction("Index");

        //    //foreach (string key in formCollection.AllKeys)
        //    //{
        //    //    Response.Write("key = " + key + " ... " + formCollection[key] + "<br/>");
        //    //}
        //    //return View();
        //}

        //[HttpPost]
        //public ActionResult Create(string name, string gender, string city, DateTime dateOfBirth)
        //{
        //    Employee employee = new Employee();
        //    employee.Name = name;
        //    employee.Gender = gender;
        //    employee.City = city;
        //    employee.DateOfBirth = dateOfBirth;

        //    EmployeeBuisnessLayer employeeBusinessLayer = new EmployeeBuisnessLayer();

        //    employeeBusinessLayer.AddEmployee(employee);
        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post(Employee employee)
        {
            //Employee employee = new Employee();
            TryUpdateModel(employee);       // UpdateModel use korle exception throw korbe.

            if (ModelState.IsValid)
            {
                EmployeeBuisnessLayer employeeBusinessLayer = new EmployeeBuisnessLayer();

                employeeBusinessLayer.AddEmployee(employee);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        [ActionName("Edit")]
        public ActionResult Edit_Get(int id)
        {
            EmployeeBuisnessLayer employeeBusinessLayer = new EmployeeBuisnessLayer();
            Employee employee = employeeBusinessLayer.employees.Single(emp => emp.Id == id);
            return View(employee);
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(int id)
        {
            EmployeeBuisnessLayer employeeBusinessLayer = new EmployeeBuisnessLayer();
            Employee employee = employeeBusinessLayer.employees.Single(emp => emp.Id == id);
            UpdateModel(employee, null, null, new string[] { "Name" });     // "name" sara shob gula k edit kora jabe. tutorial-20

            if (ModelState.IsValid)
            {
                employeeBusinessLayer.SaveEmployee(employee);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            EmployeeBuisnessLayer employeeBuisnessLayer = new EmployeeBuisnessLayer();
            employeeBuisnessLayer.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
    }
}