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
        public ActionResult Create()
        {
            ViewBag.ProblemId = new SelectList(db.Problems, "Id", "ProblemName");
            ViewBag.StudentId = new SelectList(db.Students, "Id", "UserName");
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
        public ActionResult Edit(int? id)
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
            ViewBag.ProblemId = new SelectList(db.Problems, "Id", "ProblemName", problemsStudent.ProblemId);
            ViewBag.StudentId = new SelectList(db.Students, "Id", "UserName", problemsStudent.StudentId);
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
