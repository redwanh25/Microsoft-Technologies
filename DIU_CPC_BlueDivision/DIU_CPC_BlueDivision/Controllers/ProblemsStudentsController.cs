using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DIU_CPC_BlueDivision.Models;

namespace DIU_CPC_BlueDivision.Controllers
{
    public class ProblemsStudentsController : Controller
    {
        private BlueSheetsProblemsStudentsEntities db = new BlueSheetsProblemsStudentsEntities();

        // GET: ProblemsStudents
        public ActionResult Index()
        {
            var problemsStudents = db.ProblemsStudents.Include(p => p.Problem).Include(p => p.Student);
            return View(problemsStudents.ToList());
        }

        // GET: ProblemsStudents/Details/5
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
        public ActionResult Create([Bind(Include = "Comment,IsSolved,ProblemId,StudentId")] ProblemsStudent problemsStudent)
        {
            if (ModelState.IsValid)
            {
                db.ProblemsStudents.Add(problemsStudent);
                db.SaveChanges();
                return RedirectToAction("Index");
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
        public ActionResult Edit([Bind(Include = "Comment,IsSolved,ProblemId,StudentId")] ProblemsStudent problemsStudent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(problemsStudent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProblemId = new SelectList(db.Problems, "Id", "ProblemName", problemsStudent.ProblemId);
            ViewBag.StudentId = new SelectList(db.Students, "Id", "UserName", problemsStudent.StudentId);
            return View(problemsStudent);
        }

        // GET: ProblemsStudents/Delete/5
        public ActionResult Delete(int? id)
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

        // POST: ProblemsStudents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProblemsStudent problemsStudent = db.ProblemsStudents.Find(id);
            db.ProblemsStudents.Remove(problemsStudent);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Solver(int problemId)
        {
            List<ProblemsStudent> problemsStudents = db.ProblemsStudents.Where(per => per.ProblemId == problemId && per.IsSolved == "ok").ToList();
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
