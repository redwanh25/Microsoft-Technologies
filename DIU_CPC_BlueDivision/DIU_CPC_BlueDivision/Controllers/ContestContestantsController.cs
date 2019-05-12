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
    public class ContestContestantsController : Controller
    {
        private ContestAndContestantsEntities db = new ContestAndContestantsEntities();

        // GET: ContestContestants
        public ActionResult Index(int cTrackerId)
        {

            var contestContestants = db.ContestContestants.Include(c => c.ContestantsTable).Where(per => per.ContestantsTable.ContestTrackerId == cTrackerId).Include(c => c.ContestTable).Where(per => per.ContestTable.ContestTrackerId == cTrackerId);
            ViewBag.count = db.ContestantsTables.Where(per => per.ContestTrackerId == cTrackerId).Count();
            ViewBag.contestTrackerId = cTrackerId;
            return View(contestContestants.ToList());
        }

        //[NonAction]
        //// GET: ContestContestants/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    ContestContestant contestContestant = db.ContestContestants.Find(id);
        //    if (contestContestant == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(contestContestant);
        //}

        //// GET: ContestContestants/Create
        //[NonAction]
        //public ActionResult Create()
        //{
        //    ViewBag.ContestantId = new SelectList(db.ContestantsTables, "Id", "ContestantsName");
        //    ViewBag.ContestId = new SelectList(db.ContestTables, "Id", "ContestName");
        //    return View();
        //}

        // POST: ContestContestants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost] [NonAction]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,ContestId,ContestantId,ContestTimeSolve,UpSolve")] ContestContestant contestContestant)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.ContestContestants.Add(contestContestant);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.ContestantId = new SelectList(db.ContestantsTables, "Id", "ContestantsName", contestContestant.ContestantId);
        //    ViewBag.ContestId = new SelectList(db.ContestTables, "Id", "ContestName", contestContestant.ContestId);
        //    return View(contestContestant);
        //}

        // GET: ContestContestants/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContestContestant contestContestant = db.ContestContestants.Find(id);
            if (contestContestant == null)
            {
                return HttpNotFound();
            }
            ContestContestant concon = db.ContestContestants.FirstOrDefault(per => per.Id == id);
            ViewBag.ContestantId = new SelectList(db.ContestantsTables.Where(per => per.Id == concon.ContestantId), "Id", "ContestantsName", contestContestant.ContestantId);
            ViewBag.ContestId = new SelectList(db.ContestTables.Where(per => per.Id == concon.ContestId), "Id", "ContestName", contestContestant.ContestId);
            return View(contestContestant);
        }

        // POST: ContestContestants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ContestId,ContestantId,ContestTimeSolve,UpSolve")] ContestContestant contestContestant)
        {
            ContestClass contestClass = new ContestClass();
            contestContestant.ContestId = contestClass.contestId(contestContestant.Id);
            contestContestant.ContestantId = contestClass.contestantId(contestContestant.Id);
            if (ModelState.IsValid)
            {
                db.Entry(contestContestant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ContestantId = new SelectList(db.ContestantsTables, "Id", "ContestantsName", contestContestant.ContestantId);
            ViewBag.ContestId = new SelectList(db.ContestTables, "Id", "ContestName", contestContestant.ContestId);
            return View(contestContestant);
        }

        // GET: ContestContestants/Delete/5
        //[NonAction]
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    ContestContestant contestContestant = db.ContestContestants.Find(id);
        //    if (contestContestant == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(contestContestant);
        //}

        //// POST: ContestContestants/Delete/5
        //[HttpPost, ActionName("Delete")] [NonAction]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    ContestContestant contestContestant = db.ContestContestants.Find(id);
        //    db.ContestContestants.Remove(contestContestant);
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
