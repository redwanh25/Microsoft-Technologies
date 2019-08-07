using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PersonalCalculation.DatabaseConnection;
using PersonalCalculation.Models;

namespace PersonalCalculation.Controllers
{
    public class ExpencesController : Controller
    {
        private PersonalCalculationDBEntities db = new PersonalCalculationDBEntities();

        // GET: Expences
        public ActionResult Index(int projId)
        {
            UpdateData updateData = new UpdateData();
            updateData.UpdateTotalMoneyCalculationForRentMan(projId);

            var expences = db.Expences.Where(per => per.ProjectId == projId);
            return View(expences.ToList());
        }

        // GET: Expences/Details/5
        public ActionResult Details(int? id, int projId)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expence expence = db.Expences.Find(id);
            if (expence == null)
            {
                return HttpNotFound();
            }
            return View(expence);
        }

        // GET: Expences/Create
        public ActionResult Create(int projId)
        {
            ViewBag.ProjectId = new SelectList(db.Projects.Where(per => per.Id == projId), "Id", "ProjectName");
            return View();
        }

        // POST: Expences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Cost,Purpose,Date,ProjectId")] Expence expence)
        {
            if (ModelState.IsValid)
            {
                db.Expences.Add(expence);
                db.SaveChanges();
                return RedirectToAction("Index", "Expences", new { projId = expence.ProjectId });
            }

            ViewBag.ProjectId = new SelectList(db.Projects, "Id", "ProjectName", expence.ProjectId);
            return View(expence);
        }

        // GET: Expences/Edit/5
        public ActionResult Edit(int? id, int projId)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expence expence = db.Expences.Find(id);
            if (expence == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProjectId = new SelectList(db.Projects.Where(per => per.Id == projId), "Id", "ProjectName", expence.ProjectId);
            return View(expence);
        }

        // POST: Expences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Cost,Purpose,Date,ProjectId")] Expence expence)
        {
            if (ModelState.IsValid)
            {
                db.Entry(expence).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Expences", new { projId = expence.ProjectId });
            }
            ViewBag.ProjectId = new SelectList(db.Projects, "Id", "ProjectName", expence.ProjectId);
            return View(expence);
        }

        // GET: Expences/Delete/5
        public ActionResult Delete(int? id, int projId)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expence expence = db.Expences.Find(id);
            if (expence == null)
            {
                return HttpNotFound();
            }
            return View(expence);
        }

        // POST: Expences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Expence expence = db.Expences.Find(id);
            int proId = Convert.ToInt32(expence.ProjectId);
            db.Expences.Remove(expence);
            db.SaveChanges();
            return RedirectToAction("Index", "Expences", new { projId = proId });
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
