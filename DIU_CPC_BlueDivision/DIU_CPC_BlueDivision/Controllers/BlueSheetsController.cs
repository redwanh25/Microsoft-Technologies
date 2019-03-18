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
    public class BlueSheetsController : Controller
    {
        private BlueSheetsProblemsStudentsEntities db = new BlueSheetsProblemsStudentsEntities();

        // GET: BlueSheets
        public ActionResult Index()
        {
            return View(db.BlueSheets.ToList());
        }

        // GET: BlueSheets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlueSheet blueSheet = db.BlueSheets.Find(id);
            if (blueSheet == null)
            {
                return HttpNotFound();
            }
            return View(blueSheet);
        }

        // GET: BlueSheets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlueSheets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,BlueSheetName,Date,CreatedBy")] BlueSheet blueSheet)
        {
            if (ModelState.IsValid)
            {
                blueSheet.Date = DateTime.Now;
                db.BlueSheets.Add(blueSheet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blueSheet);
        }

        // GET: BlueSheets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlueSheet blueSheet = db.BlueSheets.Find(id);
            if (blueSheet == null)
            {
                return HttpNotFound();
            }
            return View(blueSheet);
        }

        // POST: BlueSheets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,BlueSheetName,Date,CreatedBy")] BlueSheet blueSheet)
        {
            if (ModelState.IsValid)
            {
                blueSheet.Date = DateTime.Now;
                db.Entry(blueSheet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blueSheet);
        }

        // GET: BlueSheets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlueSheet blueSheet = db.BlueSheets.Find(id);
            if (blueSheet == null)
            {
                return HttpNotFound();
            }
            return View(blueSheet);
        }

        // POST: BlueSheets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DeleteDataFromDatabase deleteDataFromDatabase = new DeleteDataFromDatabase();
            deleteDataFromDatabase.deleteBlueSheets(id);

            BlueSheet blueSheet = db.BlueSheets.Find(id);
            db.BlueSheets.Remove(blueSheet);
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
