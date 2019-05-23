using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InputFromExcelFile.Models;

namespace InputFromExcelFile.Controllers
{
    public class ContestTablesController : Controller
    {
        private ConConEntities db = new ConConEntities();

        // GET: ContestTables
        public ActionResult Index()
        {
            return View(db.ContestTables.ToList());
        }

        // GET: ContestTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContestTable contestTable = db.ContestTables.Find(id);
            if (contestTable == null)
            {
                return HttpNotFound();
            }
            return View(contestTable);
        }

        // GET: ContestTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContestTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ContestName,ContestLink,Date,NumberOfProblems,Participation")] ContestTable contestTable)
        {
            if (ModelState.IsValid)
            {
                db.ContestTables.Add(contestTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contestTable);
        }

        // GET: ContestTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContestTable contestTable = db.ContestTables.Find(id);
            if (contestTable == null)
            {
                return HttpNotFound();
            }
            return View(contestTable);
        }

        // POST: ContestTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ContestName,ContestLink,Date,NumberOfProblems,Participation")] ContestTable contestTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contestTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contestTable);
        }

        // GET: ContestTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContestTable contestTable = db.ContestTables.Find(id);
            if (contestTable == null)
            {
                return HttpNotFound();
            }
            return View(contestTable);
        }

        // POST: ContestTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContestTable contestTable = db.ContestTables.Find(id);
            db.ContestTables.Remove(contestTable);
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
