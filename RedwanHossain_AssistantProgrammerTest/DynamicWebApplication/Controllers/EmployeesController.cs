using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DynamicWebApplication.Models;

namespace DynamicWebApplication.Controllers
{
    public class EmployeesController : Controller
    {
        private GHITL_DBEntities db = new GHITL_DBEntities();

        // GET: Employees
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            List<string> listOfDepartment = new List<string> { "Engineering", "Finance", "Accounting", "Physician", "Management", "Development"};
            List<string> listOfCity = new List<string> { "Dhaka", "Chittagong", "Khulna", "Rajshahi", "Narayanganj", "Gazipur", "Sylhet", "Barishal", "Rangpur", "Comilla", "Mymensingh"};
            ViewBag.Departments = listOfDepartment.Select(r => new SelectListItem { Value = r.ToString(), Text = r.ToString() }).ToList();
            ViewBag.Cities = listOfCity.Select(r => new SelectListItem { Value = r.ToString(), Text = r.ToString() }).ToList();
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Gender,Department,City")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }

            List<string> listOfDepartment = new List<string> { "Engineering", "Finance", "Accounting", "Physician", "Management", "Development" };
            List<string> listOfCity = new List<string> { "Dhaka", "Chittagong", "Khulna", "Rajshahi", "Narayanganj", "Gazipur", "Sylhet", "Barishal", "Rangpur", "Comilla", "Mymensingh" };
            ViewBag.Departments = listOfDepartment.Select(r => new SelectListItem { Value = r.ToString(), Text = r.ToString() }).ToList();
            ViewBag.Cities = listOfCity.Select(r => new SelectListItem { Value = r.ToString(), Text = r.ToString() }).ToList();

            return View(employee);
        }

        // POST: Employees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Gender,Department,City")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
