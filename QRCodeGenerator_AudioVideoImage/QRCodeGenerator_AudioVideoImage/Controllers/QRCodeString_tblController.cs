using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QRCodeGenerator_AudioVideoImage.Models;

namespace QRCodeGenerator_AudioVideoImage.Controllers
{
    public class QRCodeString_tblController : Controller
    {
        private QRCodeStringEntities db = new QRCodeStringEntities();

        // GET: QRCodeString_tbl
        public ActionResult Index()
        {
            return View(db.QRCodeString_tbl.ToList());
        }

        // GET: QRCodeString_tbl/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QRCodeString_tbl qRCodeString_tbl = db.QRCodeString_tbl.Find(id);
            if (qRCodeString_tbl == null)
            {
                return HttpNotFound();
            }
            return View(qRCodeString_tbl);
        }

        // GET: QRCodeString_tbl/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QRCodeString_tbl/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Date,QRCodeImage,QRCodeString")] QRCodeString_tbl qRCodeString_tbl)
        {
            if (ModelState.IsValid)
            {
                db.QRCodeString_tbl.Add(qRCodeString_tbl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(qRCodeString_tbl);
        }

        // GET: QRCodeString_tbl/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QRCodeString_tbl qRCodeString_tbl = db.QRCodeString_tbl.Find(id);
            if (qRCodeString_tbl == null)
            {
                return HttpNotFound();
            }
            return View(qRCodeString_tbl);
        }

        // POST: QRCodeString_tbl/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Date,QRCodeImage,QRCodeString")] QRCodeString_tbl qRCodeString_tbl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(qRCodeString_tbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(qRCodeString_tbl);
        }

        // GET: QRCodeString_tbl/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QRCodeString_tbl qRCodeString_tbl = db.QRCodeString_tbl.Find(id);
            if (qRCodeString_tbl == null)
            {
                return HttpNotFound();
            }
            return View(qRCodeString_tbl);
        }

        // POST: QRCodeString_tbl/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QRCodeString_tbl qRCodeString_tbl = db.QRCodeString_tbl.Find(id);
            db.QRCodeString_tbl.Remove(qRCodeString_tbl);
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
