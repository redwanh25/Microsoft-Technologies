﻿using System;
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
    public class ContestantsTablesController : Controller
    {
        private ConConEntities db = new ConConEntities();

        // GET: ContestantsTables
        public ActionResult Index()
        {
            return View(db.ContestantsTables.ToList());
        }

        // GET: ContestantsTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContestantsTable contestantsTable = db.ContestantsTables.Find(id);
            if (contestantsTable == null)
            {
                return HttpNotFound();
            }
            return View(contestantsTable);
        }

        // GET: ContestantsTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContestantsTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ContestantsName,StudentId,CFHandle,CFHandleLink,Score,TotalSolve,TotalParticipation,OnlineParticipation,SolveCountOnsite,SolveCountUpsolves,AverageSolvePerContest")] ContestantsTable contestantsTable)
        {
            if (ModelState.IsValid)
            {
                db.ContestantsTables.Add(contestantsTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contestantsTable);
        }

        // GET: ContestantsTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContestantsTable contestantsTable = db.ContestantsTables.Find(id);
            if (contestantsTable == null)
            {
                return HttpNotFound();
            }
            return View(contestantsTable);
        }

        // POST: ContestantsTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ContestantsName,StudentId,CFHandle,CFHandleLink,Score,TotalSolve,TotalParticipation,OnlineParticipation,SolveCountOnsite,SolveCountUpsolves,AverageSolvePerContest")] ContestantsTable contestantsTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contestantsTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contestantsTable);
        }

        // GET: ContestantsTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContestantsTable contestantsTable = db.ContestantsTables.Find(id);
            if (contestantsTable == null)
            {
                return HttpNotFound();
            }
            return View(contestantsTable);
        }

        // POST: ContestantsTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContestantsTable contestantsTable = db.ContestantsTables.Find(id);
            db.ContestantsTables.Remove(contestantsTable);
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
