using CrudOperation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CrudOperation.Controllers
{
    public class RedwanController : Controller
    {
        CrudOperationEntities db = new CrudOperationEntities();
        //GET: Redwan
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetEmployees()
        {
            var employees = db.Employees.OrderBy(a => a.FirstName).ToList();

            return Json(new { data = employees }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Save(int id)
        {
            var v = db.Employees.FirstOrDefault(a => a.Id == id);
            return View(v);
        }

        [HttpPost]
        public ActionResult Save(Employee employee)
        {
            bool check = false;
            if (ModelState.IsValid)
            {
                if(employee.Id > 0)
                {
                    Employee v = db.Employees.FirstOrDefault(a => a.Id == employee.Id);
                    if(v != null)
                    {
                        v.FirstName = employee.FirstName;
                        v.LastName = employee.LastName;
                        v.City = employee.City;
                        v.EmailId = employee.EmailId;
                        v.Country = employee.Country;
                    }
                }
                else
                {
                     db.Employees.Add(employee);
                }
                db.SaveChanges();
                check = true;
            }
            return new JsonResult { Data = new { status = check } };
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var employee = db.Employees.Find(id);
            if(employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteEmployee(int id)
        {
            bool check = false;
            Employee employee = db.Employees.Find(id);
            if(employee != null)
            {
                db.Employees.Remove(employee);
                db.SaveChanges();
                check = true;
            }
            return new JsonResult { Data = new { status = check } };
            
        }
    }
}