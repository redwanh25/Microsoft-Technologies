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
    public class ContestTrackersController : Controller
    {
        private ContestAndContestantsEntities db = new ContestAndContestantsEntities();

        // GET: ContestTrackers
        public ActionResult Index()
        {
            return View(db.ContestTrackers.ToList());
        }

        // GET: ContestTrackers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContestTracker contestTracker = db.ContestTrackers.Find(id);
            if (contestTracker == null)
            {
                return HttpNotFound();
            }
            return View(contestTracker);
        }

        // GET: ContestTrackers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContestTrackers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ContestYear,Date,CreatedBy")] ContestTracker contestTracker)
        {
            if (ModelState.IsValid)
            {
                db.ContestTrackers.Add(contestTracker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contestTracker);
        }

        // GET: ContestTrackers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContestTracker contestTracker = db.ContestTrackers.Find(id);
            if (contestTracker == null)
            {
                return HttpNotFound();
            }
            return View(contestTracker);
        }

        // POST: ContestTrackers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ContestYear,Date,CreatedBy")] ContestTracker contestTracker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contestTracker).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contestTracker);
        }

        // GET: ContestTrackers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContestTracker contestTracker = db.ContestTrackers.Find(id);
            if (contestTracker == null)
            {
                return HttpNotFound();
            }
            return View(contestTracker);
        }

        // POST: ContestTrackers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DeleteDataFromDatabase deleteDataFromDatabase = new DeleteDataFromDatabase();
            deleteDataFromDatabase.deleteContestTracker(id);

            ContestTracker contestTracker = db.ContestTrackers.Find(id);
            db.ContestTrackers.Remove(contestTracker);
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
