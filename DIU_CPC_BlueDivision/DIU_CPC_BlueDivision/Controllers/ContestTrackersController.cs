using System;
using System.Collections.Generic;
using System.Configuration;
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
    public class ContestTrackersController : Controller
    {
        private ContestAndContestantsEntities db = new ContestAndContestantsEntities();

        private string superAdmin = ConfigurationManager.AppSettings["SuperAdmin"].ToString();
        private string admin = ConfigurationManager.AppSettings["Admin"].ToString();
        private string student = ConfigurationManager.AppSettings["Student"].ToString();
        private string admin_1 = ConfigurationManager.AppSettings["Admin_1"].ToString();

        // GET: ContestTrackers
        public ActionResult Index()
        {
            return View(db.ContestTrackers.ToList());

        }

        // GET: ContestTrackers/Details/5
        [NonAction]
        public ActionResult Details(int? id)
        {
            string U_id = "", str = "";
            U_id = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(U_id))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(U_id);
            }
            if (str == student)
            {
                throw new Exception();
            }

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
            string U_id = "", str = "";
            U_id = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(U_id))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(U_id);
            }
            if (str == student)
            {
                throw new Exception();
            }

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
        [NonAction]
        public ActionResult Edit(int? id)
        {
            string U_id = "", str = "";
            U_id = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(U_id))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(U_id);
            }
            if (str == student)
            {
                throw new Exception();
            }

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
        [NonAction]
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
            string U_id = "", str = "";
            U_id = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(U_id))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(U_id);
            }
            if (str == student)
            {
                throw new Exception();
            }

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
