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
    public class GetFromRentMenController : Controller
    {
        private PersonalCalculationDBEntities db = new PersonalCalculationDBEntities();

        // GET: GetFromRentMen
        public ActionResult Index(int projId)
        {
            UpdateData updateData = new UpdateData();
            updateData.UpdateTotalMoneyCalculationForRentMan(projId);

            var getFromRentMen = db.GetFromRentMen.Where(per => per.ProjectId == projId);
            return View(getFromRentMen.ToList());
        }

        // GET: GetFromRentMen/Details/5
        public ActionResult Details(int? id, int projId)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GetFromRentMan getFromRentMan = db.GetFromRentMen.Find(id);
            if (getFromRentMan == null)
            {
                return HttpNotFound();
            }
            return View(getFromRentMan);
        }

        // GET: GetFromRentMen/Create
        public ActionResult Create(int projId)
        {
            ViewBag.ProjectId = new SelectList(db.Projects.Where(per => per.Id == projId), "Id", "ProjectName");
            return View();
        }

        // POST: GetFromRentMen/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ReceiveMoney,DueMoney,Rent,Date,ProjectId")] GetFromRentMan getFromRentMan)
        {
            if (ModelState.IsValid)
            {
                getFromRentMan.Rent = db.Projects.FirstOrDefault(per => per.Id == getFromRentMan.ProjectId).Rent;
                getFromRentMan.DueMoney = getFromRentMan.ReceiveMoney - getFromRentMan.Rent;
                db.GetFromRentMen.Add(getFromRentMan);
                db.SaveChanges();
                return RedirectToAction("Index", "GetFromRentMen", new { projId = getFromRentMan.ProjectId });
            }

            ViewBag.ProjectId = new SelectList(db.Projects, "Id", "ProjectName", getFromRentMan.ProjectId);
            return View(getFromRentMan);
        }

        // GET: GetFromRentMen/Edit/5
        public ActionResult Edit(int? id, int projId)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GetFromRentMan getFromRentMan = db.GetFromRentMen.Find(id);
            if (getFromRentMan == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProjectId = new SelectList(db.Projects.Where(per => per.Id == projId), "Id", "ProjectName", getFromRentMan.ProjectId);
            return View(getFromRentMan);
        }

        // POST: GetFromRentMen/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ReceiveMoney,DueMoney,Rent,Date,ProjectId")] GetFromRentMan getFromRentMan)
        {
            if (ModelState.IsValid)
            {
                getFromRentMan.Rent = db.Projects.FirstOrDefault(per => per.Id == getFromRentMan.ProjectId).Rent;
                getFromRentMan.DueMoney = getFromRentMan.ReceiveMoney - getFromRentMan.Rent;
                db.Entry(getFromRentMan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "GetFromRentMen", new { projId = getFromRentMan.ProjectId });
            }
            ViewBag.ProjectId = new SelectList(db.Projects, "Id", "ProjectName", getFromRentMan.ProjectId);
            return View(getFromRentMan);
        }

        // GET: GetFromRentMen/Delete/5
        public ActionResult Delete(int? id, int projId)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GetFromRentMan getFromRentMan = db.GetFromRentMen.Find(id);
            if (getFromRentMan == null)
            {
                return HttpNotFound();
            }
            return View(getFromRentMan);
        }

        // POST: GetFromRentMen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GetFromRentMan getFromRentMan = db.GetFromRentMen.Find(id);
            int proId = Convert.ToInt32(getFromRentMan.ProjectId);
            db.GetFromRentMen.Remove(getFromRentMan);
            db.SaveChanges();
            return RedirectToAction("Index", "GetFromRentMen", new { projId = proId });
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
