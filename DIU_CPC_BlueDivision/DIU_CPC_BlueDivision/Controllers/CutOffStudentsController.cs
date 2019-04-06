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
    public class CutOffStudentsController : Controller
    {
        private BlueSheetsProblemsStudentsEntities db = new BlueSheetsProblemsStudentsEntities();

        private string superAdmin = ConfigurationManager.AppSettings["SuperAdmin"].ToString();
        private string admin = ConfigurationManager.AppSettings["Admin"].ToString();
        private string student = ConfigurationManager.AppSettings["Student"].ToString();

        // GET: CutOffStudents
        public ActionResult Index(string semester)
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

            List<Student> list = db.Students.Where(per => per.MuteOrUnmute == "Mute" && per.Semester == semester).ToList();
            return View(list);
        }

        //// GET: CutOffStudents/Details/5
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

        //// GET: CutOffStudents/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: CutOffStudents/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,UserName,StudentId,FullName,EmailAddress,PhoneNumber,Semester,SolveCount,CodeForcesId,MuteOrUnmute")] Student student)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Students.Add(student);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(student);
        //}

        //// GET: CutOffStudents/Edit/5
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

        //// POST: CutOffStudents/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,UserName,StudentId,FullName,EmailAddress,PhoneNumber,Semester,SolveCount,CodeForcesId,MuteOrUnmute")] Student student)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(student).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(student);
        //}

        //// GET: CutOffStudents/Delete/5
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

        //// POST: CutOffStudents/Delete/5
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
        public ActionResult UnmuteStudent(string id)
        {
            ListOfAllAdminsAndStudents listOfAllAdminsAndStudents = new ListOfAllAdminsAndStudents();
            listOfAllAdminsAndStudents.UpdateStudentsUnmute(id);

            Student student = db.Students.FirstOrDefault(per => per.Id == id);
            return RedirectToAction("Index", "CutOffStudents", new { semester = student.Semester });
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
