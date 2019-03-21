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
    public class ProblemsStudentsController : Controller
    {
        private BlueSheetsProblemsStudentsEntities db = new BlueSheetsProblemsStudentsEntities();

        // GET: ProblemsStudents
        [NonAction]
        public ActionResult Index()
        {
            var problemsStudents = db.ProblemsStudents.Include(p => p.Problem).Include(p => p.Student);
            return View(problemsStudents.ToList());
        }

        // GET: ProblemsStudents/Details/5
        [NonAction]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProblemsStudent problemsStudent = db.ProblemsStudents.Find(id);
            if (problemsStudent == null)
            {
                return HttpNotFound();
            }
            return View(problemsStudent);
        }

        // GET: ProblemsStudents/Create
        public ActionResult Create(int problemId, string userName)
        {
            //ViewBag.ProblemId = new SelectList(db.Problems, "Id", "ProblemName");
            //ViewBag.StudentId = new SelectList(db.Students, "Id", "UserName");

            ViewBag.ProblemId = new SelectList(db.Problems.Where(per => per.Id == problemId), "Id", "ProblemName");
            ViewBag.StudentId = new SelectList(db.Students.Where(per => per.UserName == userName), "Id", "UserName");
            return View();
        }

        // POST: ProblemsStudents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Comment,IsSolved,SolutionLink,ShareSolutionLink,ProblemId,StudentId")] ProblemsStudent problemsStudent)
        {
            string userId = "", joinSem = "";
            userId = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(userId))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                joinSem = aspNetUsersBusinessLayer.GetJoinSemester(userId);
            }

            if (ModelState.IsValid)
            {
                db.ProblemsStudents.Add(problemsStudent);
                db.SaveChanges();
                return RedirectToAction("Index", "Problems", new { id_Or_SheetName = joinSem });
            }

            ViewBag.ProblemId = new SelectList(db.Problems, "Id", "ProblemName", problemsStudent.ProblemId);
            ViewBag.StudentId = new SelectList(db.Students, "Id", "UserName", problemsStudent.StudentId);
            return View(problemsStudent);
        }

        // GET: ProblemsStudents/Edit/5
        public ActionResult Edit(int problemId, string userName)
        {
            if (db.ProblemsStudents.FirstOrDefault(per => per.Problem.Id == problemId && per.Student.UserName == userName) == null)
            {
                return RedirectToAction("Create", "ProblemsStudents", new { problemId, userName });
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProblemsStudent problemsStudent = db.ProblemsStudents.FirstOrDefault(per => per.Problem.Id == problemId && per.Student.UserName == userName);
            if (problemsStudent == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProblemId = new SelectList(db.Problems.Where(per => per.Id == problemId), "Id", "ProblemName", problemsStudent.ProblemId);
            ViewBag.StudentId = new SelectList(db.Students.Where(per => per.UserName == userName), "Id", "UserName", problemsStudent.StudentId);
            return View(problemsStudent);
        }

        // POST: ProblemsStudents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Comment,IsSolved,SolutionLink,ShareSolutionLink,ProblemId,StudentId")] ProblemsStudent problemsStudent)
        {
            string userId = "", joinSem = "";
            userId = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(userId))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                joinSem = aspNetUsersBusinessLayer.GetJoinSemester(userId);
            }
            if (ModelState.IsValid)
            {
                db.Entry(problemsStudent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Problems", new { id_Or_SheetName = joinSem });
            }
            ViewBag.ProblemId = new SelectList(db.Problems, "Id", "ProblemName", problemsStudent.ProblemId);
            ViewBag.StudentId = new SelectList(db.Students, "Id", "UserName", problemsStudent.StudentId);
            return View(problemsStudent);
        }

        // GET: ProblemsStudents/Delete/5
        [NonAction]
        public ActionResult Delete(int? problemId, string studentId)
        {
            if (problemId == null && studentId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProblemsStudent problemsStudent = db.ProblemsStudents.FirstOrDefault(per => per.ProblemId == problemId && per.StudentId == studentId);
            if (problemsStudent == null)
            {
                return HttpNotFound();
            }
            return View(problemsStudent);
        }

        // POST: ProblemsStudents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [NonAction]
        public ActionResult DeleteConfirmed(int? problemId, string studentId)
        {
            ProblemsStudent problemsStudent = db.ProblemsStudents.FirstOrDefault(per => per.ProblemId == problemId && per.StudentId == studentId);
            db.ProblemsStudents.Remove(problemsStudent);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Solver(int problemId)
        {
            //int problemCount = db.ProblemsStudents.Where(per => per.ProblemId == problemId && per.IsSolved == "Accepted").ToList().Count;
            //ProblemsClass pc = new ProblemsClass();
            //pc.updateProblemSolverCount(problemId, problemCount);

            List<ProblemsStudent> problemsStudents = db.ProblemsStudents.Where(per => per.ProblemId == problemId).ToList();   //&& per.IsSolved == "Accepted"
            return View(problemsStudents);
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
