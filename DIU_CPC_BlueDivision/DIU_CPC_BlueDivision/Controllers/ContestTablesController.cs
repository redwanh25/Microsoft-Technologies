using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DIU_CPC_BlueDivision.DatabaseConnection;
using DIU_CPC_BlueDivision.Models;

namespace DIU_CPC_BlueDivision.Controllers
{
    public class ContestTablesController : Controller
    {
        private ContestAndContestantsEntities db = new ContestAndContestantsEntities();

        // GET: ContestTables
        public ActionResult Index(int cTrackerId)
        {
            List<ContestTable> list = db.ContestTables.Where(per => per.ContestTrackerId == cTrackerId).ToList();
            return View(list);
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
        public ActionResult Create(int ContestTrackerId)
        {
            ViewBag.ContestTrackerId = new SelectList(db.ContestTrackers.Where(per => per.Id == ContestTrackerId), "Id", "ContestYear");
            return View();
        }

        // POST: ContestTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ContestName,ContestLink,Date,NumberOfProblems,Participation,ContestTrackerId")] ContestTable contestTable)
        {
            if (ModelState.IsValid)
            {
                db.ContestTables.Add(contestTable);
                db.SaveChanges();
                return RedirectToAction("Index", "ContestTables", new { cTrackerId = contestTable.ContestTrackerId});
            }
            ViewBag.ContestTrackerId = new SelectList(db.ContestTrackers.Where(per => per.Id == contestTable.ContestTrackerId), "Id", "ContestYear");
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
            ContestTable contestTable1 = db.ContestTables.FirstOrDefault(per => per.Id == id);
            ViewBag.ContestTrackerId = new SelectList(db.ContestTrackers.Where(per => per.Id == contestTable1.ContestTrackerId), "Id", "ContestYear");
            return View(contestTable);
        }

        // POST: ContestTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ContestName,ContestLink,Date,NumberOfProblems,Participation,ContestTrackerId")] ContestTable contestTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contestTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "ContestTables", new { cTrackerId = contestTable.ContestTrackerId });
            }
            ViewBag.ContestTrackerId = new SelectList(db.ContestTrackers.Where(per => per.Id == contestTable.ContestTrackerId), "Id", "ContestYear");
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
            DeleteDataFromDatabase deleteDataFromDatabase = new DeleteDataFromDatabase();
            deleteDataFromDatabase.deleteContest(id);

            ContestTable contestTable = db.ContestTables.Find(id);
            int cTId = (int) contestTable.ContestTrackerId;
            db.ContestTables.Remove(contestTable);
            db.SaveChanges();
            return RedirectToAction("Index", "ContestTables", new { cTrackerId = cTId });
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
