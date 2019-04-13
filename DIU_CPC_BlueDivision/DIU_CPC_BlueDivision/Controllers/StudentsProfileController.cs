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
    public class StudentsProfileController : Controller
    {
        private BlueSheetsProblemsStudentsEntities db = new BlueSheetsProblemsStudentsEntities();

        // GET: StudentsProfile
        public ActionResult Index()
        {
            string userId = User.Identity.GetUserId();
            Student student = db.Students.FirstOrDefault(per => per.Id == userId);
            return View(student);
        }

        // GET: StudentsProfile/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: StudentsProfile/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StudentId,FullName,PhoneNumber,CodeForcesId")] Student student)
        {
            StudentsInformation_Retrive studentsInformation = new StudentsInformation_Retrive();
            student.UserName = studentsInformation.GetUserName(student.Id);
            student.EmailAddress = studentsInformation.GetEmailId(student.Id);
            student.Semester = studentsInformation.GetSemester(student.Id);
            student.SolveCount = studentsInformation.GetSolveCount(student.Id);
            student.MuteOrUnmute = studentsInformation.GetMuteOrUnmute(student.Id);
            student.Request = studentsInformation.GetRequest(student.Id);

            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();

                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                aspNetUsersBusinessLayer.UpdatePhoneNumber(student.Id, student.PhoneNumber);

                return RedirectToAction("Index");
            }
            return View(student);
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
