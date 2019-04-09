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
    public class RequestStudentsController : Controller
    {
        private BlueSheetsProblemsStudentsEntities db = new BlueSheetsProblemsStudentsEntities();
        string student = ConfigurationManager.AppSettings["Student"].ToString();

        // GET: RequestStudents
        public ActionResult Index()
        {           
            string str = "", secureCode = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                secureCode = aspNetUsersBusinessLayer.GetSecureCode(str);
            }
            if (secureCode == student)
            {
                throw new Exception();
            }

            List<Student> list = db.Students.Where(per => per.Request == 1).ToList();
            List<Student> students = list.OrderBy(per => per.Semester).ToList();
            return View(students);
        }

        [HttpPost]
        public ActionResult UnmuteStudentRequest(string id)
        {
            ListOfAllAdminsAndStudents listOfAllAdminsAndStudents = new ListOfAllAdminsAndStudents();
            listOfAllAdminsAndStudents.UpdateStudentsUnmute(id);

            return RedirectToAction("Index");
        }

        //// GET: RequestStudents/Details/5
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

        //// GET: RequestStudents/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: RequestStudents/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,UserName,StudentId,FullName,EmailAddress,PhoneNumber,Semester,SolveCount,CodeForcesId,MuteOrUnmute,Request")] Student student)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Students.Add(student);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(student);
        //}

        //// GET: RequestStudents/Edit/5
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

        //// POST: RequestStudents/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,UserName,StudentId,FullName,EmailAddress,PhoneNumber,Semester,SolveCount,CodeForcesId,MuteOrUnmute,Request")] Student student)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(student).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(student);
        //}

        //// GET: RequestStudents/Delete/5
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

        //// POST: RequestStudents/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(string id)
        //{
        //    Student student = db.Students.Find(id);
        //    db.Students.Remove(student);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
