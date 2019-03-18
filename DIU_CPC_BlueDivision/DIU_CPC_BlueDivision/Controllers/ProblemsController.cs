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
    public class ProblemsController : Controller
    {
        private BlueSheetsProblemsStudentsEntities db = new BlueSheetsProblemsStudentsEntities();

        // GET: Problems
        public ActionResult Index(string id_Or_SheetName)
        {
            // var problems = db.Problems.Include(p => p.BlueSheet);

            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(str);
            }
            if (str != "1234_U1")
            {
                List<Problem> problems = db.Problems.Where(per => per.BlueSheet.BlueSheetName == id_Or_SheetName).ToList();
                return View(problems);
            }
            else
            {
                int id = Convert.ToInt32(id_Or_SheetName);
                List<Problem> problems = db.Problems.Where(per => per.BlueSheetId == id).ToList();
                return View(problems);
            }

        }

        // GET: Problems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Problem problem = db.Problems.Find(id);
            if (problem == null)
            {
                return HttpNotFound();
            }
            return View(problem);
        }

        // GET: Problems/Create
        public ActionResult Create()
        {
            ViewBag.BlueSheetId = new SelectList(db.BlueSheets, "Id", "BlueSheetName");
            return View();
        }

        // POST: Problems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ProblemName,ProblemLink,Comment,BlueSheetId")] Problem problem)
        {
            if (ModelState.IsValid)
            {
                db.Problems.Add(problem);
                db.SaveChanges();
                return RedirectToAction("Index", "Problems", new { id_Or_SheetName = problem.BlueSheetId });
            }

            ViewBag.BlueSheetId = new SelectList(db.BlueSheets, "Id", "BlueSheetName", problem.BlueSheetId);
            return View(problem);
        }

        // GET: Problems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Problem problem = db.Problems.Find(id);
            if (problem == null)
            {
                return HttpNotFound();
            }
            ViewBag.BlueSheetId = new SelectList(db.BlueSheets, "Id", "BlueSheetName", problem.BlueSheetId);
            return View(problem);
        }

        // POST: Problems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ProblemName,ProblemLink,Comment,BlueSheetId")] Problem problem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(problem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Problems", new { id_Or_SheetName = problem.BlueSheetId });
            }
            ViewBag.BlueSheetId = new SelectList(db.BlueSheets, "Id", "BlueSheetName", problem.BlueSheetId);
            return View(problem);
        }

        // GET: Problems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Problem problem = db.Problems.Find(id);
            if (problem == null)
            {
                return HttpNotFound();
            }
            return View(problem);
        }

        // POST: Problems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DeleteDataFromDatabase deleteDataFromDatabase = new DeleteDataFromDatabase();
            deleteDataFromDatabase.deleteProblemsStudents(id);

            Problem problem = db.Problems.Find(id);
            int? Id = problem.BlueSheetId;
            db.Problems.Remove(problem);
            db.SaveChanges();
            return RedirectToAction("Index", "Problems", new { Id });
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
