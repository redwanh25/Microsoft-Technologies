using System;
using System.Collections.Generic;
using System.Configuration;
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
    public class ListOfStudentsController : Controller
    {
        private BlueSheetsProblemsStudentsEntities db = new BlueSheetsProblemsStudentsEntities();

        private string superAdmin = ConfigurationManager.AppSettings["SuperAdmin"].ToString();
        private string admin = ConfigurationManager.AppSettings["Admin"].ToString();
        private string student = ConfigurationManager.AppSettings["Student"].ToString();

        // GET: ListOfStudents
        public ActionResult Index()
        {
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(str);
            }
            if (str == student)
            {
                throw new Exception();
            }
            return View(db.Students.ToList());
        }

        //// GET: ListOfStudents/Details/5
        //public ActionResult Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Student student = db.Students.Find(id);
        //    if (student == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(student);
        //}

        //// GET: ListOfStudents/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: ListOfStudents/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,UserName,StudentId,FullName,EmailAddress,PhoneNumber,Semester,SolveCount,CodeForcesId")] Student student)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Students.Add(student);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(student);
        //}

        //// GET: ListOfStudents/Edit/5
        //public ActionResult Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Student student = db.Students.Find(id);
        //    if (student == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(student);
        //}

        //// POST: ListOfStudents/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,UserName,StudentId,FullName,EmailAddress,PhoneNumber,Semester,SolveCount,CodeForcesId")] Student student)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(student).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(student);
        //}

        //// GET: ListOfStudents/Delete/5
        //public ActionResult Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Student student = db.Students.Find(id);
        //    if (student == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(student);
        //}

        //// POST: ListOfStudents/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(string id)
        //{
        //    Student student = db.Students.Find(id);
        //    db.Students.Remove(student);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public ActionResult DeleteStudent(string id)
        {
            ListOfAllAdminsAndStudents listOfAllAdminsAndStudents = new ListOfAllAdminsAndStudents();
            listOfAllAdminsAndStudents.DeleteStudents(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult MuteStudent(string id)
        {
            ListOfAllAdminsAndStudents listOfAllAdminsAndStudents = new ListOfAllAdminsAndStudents();
            listOfAllAdminsAndStudents.UpdateStudentsMute(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult UnmuteStudent(string id)
        {
            ListOfAllAdminsAndStudents listOfAllAdminsAndStudents = new ListOfAllAdminsAndStudents();
            listOfAllAdminsAndStudents.UpdateStudentsUnmute(id);
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
