using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DIU_CPC_BlueDivision.DatabaseConnection;
using DIU_CPC_BlueDivision.DifferentLayout_Database;
using DIU_CPC_BlueDivision.Models;
using Microsoft.AspNet.Identity;

namespace DIU_CPC_BlueDivision.Controllers
{
    public class CutOffStudentsController : Controller
    {
        private CutOffStudentsEntities db = new CutOffStudentsEntities();

        // GET: CutOffStudents
        public ActionResult Index()
        {
            return View(db.CutOffStudents.OrderByDescending(per => per.Id).ToList());
        }

        [NonAction]
        // GET: CutOffStudents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CutOffStudent cutOffStudent = db.CutOffStudents.Find(id);
            if (cutOffStudent == null)
            {
                return HttpNotFound();
            }
            return View(cutOffStudent);
        }

        [NonAction]
        // GET: CutOffStudents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CutOffStudents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [NonAction]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UserId,UserName,StudentId,FullName,EmailAddress,PhoneNumber,Semester,SolveCount,CodeForcesId")] CutOffStudent cutOffStudent)
        {
            if (ModelState.IsValid)
            {
                db.CutOffStudents.Add(cutOffStudent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cutOffStudent);
        }

        [NonAction]
        // GET: CutOffStudents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CutOffStudent cutOffStudent = db.CutOffStudents.Find(id);
            if (cutOffStudent == null)
            {
                return HttpNotFound();
            }
            return View(cutOffStudent);
        }

        // POST: CutOffStudents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [NonAction]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UserId,UserName,StudentId,FullName,EmailAddress,PhoneNumber,Semester,SolveCount,CodeForcesId")] CutOffStudent cutOffStudent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cutOffStudent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cutOffStudent);
        }

        [NonAction]
        // GET: CutOffStudents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CutOffStudent cutOffStudent = db.CutOffStudents.Find(id);
            if (cutOffStudent == null)
            {
                return HttpNotFound();
            }
            return View(cutOffStudent);
        }

        [NonAction]
        // POST: CutOffStudents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CutOffStudent cutOffStudent = db.CutOffStudents.Find(id);
            db.CutOffStudents.Remove(cutOffStudent);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(str);
            }
            if (str != "1234_U1")
            {
                throw new Exception();
            }
            ProblemsClass problemsClass = new ProblemsClass();
            problemsClass.DeleteCutOffStudents(id);
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
