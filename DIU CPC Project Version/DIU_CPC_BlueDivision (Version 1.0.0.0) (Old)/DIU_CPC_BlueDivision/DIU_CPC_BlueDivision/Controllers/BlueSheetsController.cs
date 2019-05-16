﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
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
    public class BlueSheetsController : Controller
    {
        private BlueSheetsProblemsStudentsEntities db = new BlueSheetsProblemsStudentsEntities();

        // GET: BlueSheets
        public ActionResult Index()
        {
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(str);
            }
            if (str != "1234_U1")
            {
                throw new Exception();
            }

            List<BlueSheet> blueSheets = db.BlueSheets.OrderByDescending(per => per.Id).ToList();
            return View(blueSheets);
        }

        // GET: BlueSheets/Details/5
        public ActionResult Details(int? id)
        {
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(str);
            }
            if (str != "1234_U1")
            {
                throw new Exception();
            }

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
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(str);
            }
            if (str != "1234_U1")
            {
                throw new Exception();
            }

            return View();
        }

        // POST: BlueSheets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,BlueSheetName,Date,CreatedBy")] BlueSheet blueSheet)
        {
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(str);
            }
            if (str != "1234_U1")
            {
                throw new Exception();
            }

            if (ModelState.IsValid)
            {
                blueSheet.Date = DateTime.Now;
                db.BlueSheets.Add(blueSheet);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    //check for Exception type as sql Exception 
                    if (ex.GetBaseException().GetType() == typeof(SqlException))
                    {
                        ModelState.AddModelError("BlueSheetName", "BlueSheetName is already exist");
                        return View(blueSheet);
                    }
                    else
                    {
                        ModelState.AddModelError("BlueSheetName", "Something is wrong");
                        return View(blueSheet);
                    }
                }
                return RedirectToAction("Index");
            }

            return View(blueSheet);
        }

        // GET: BlueSheets/Edit/5
        public ActionResult Edit(int? id)
        {
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(str);
            }
            if (str != "1234_U1")
            {
                throw new Exception();
            }

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
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(str);
            }
            if (str != "1234_U1")
            {
                throw new Exception();
            }

            // aita korle error dey...
            //BlueSheet blue = db.BlueSheets.Single(per => per.Id == blueSheet.Id);
            //blueSheet.BlueSheetName = blue.BlueSheetName;

            BlueSheetNameRetrive blue = new BlueSheetNameRetrive();
            blueSheet.BlueSheetName = blue.getBlueSheetName(blueSheet.Id);

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
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(str);
            }
            if (str != "1234_U1")
            {
                throw new Exception();
            }

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
            string str = "";
            str = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(str))
            {
                AspNetUsersBusinessLayer aspNetUsersBusinessLayer = new AspNetUsersBusinessLayer();
                str = aspNetUsersBusinessLayer.GetSecureCode(str);
            }
            if (str != "1234_U1")
            {
                throw new Exception();
            }

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