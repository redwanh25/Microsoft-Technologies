using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Software_Company_WebApplication.Models;

namespace Software_Company_WebApplication.Controllers
{
    public class FoundationDayTShirtDistributionsController : Controller
    {
        private FoundationDayTShirtDistributionDBEntities db = new FoundationDayTShirtDistributionDBEntities();

        // GET: FoundationDayTShirtDistributions
        public ActionResult Index()
        {
            List<FoundationDayTShirtDistribution> list = db.FoundationDayTShirtDistributions.ToList();
            list = list.OrderByDescending(it => it.ID).ToList();
            return View(list);
            //return View(db.FoundationDayTShirtDistributions.ToList());
        }

        // GET: FoundationDayTShirtDistributions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoundationDayTShirtDistribution foundationDayTShirtDistribution = db.FoundationDayTShirtDistributions.Find(id);
            if (foundationDayTShirtDistribution == null)
            {
                return HttpNotFound();
            }
            return View(foundationDayTShirtDistribution);
        }

        // GET: FoundationDayTShirtDistributions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FoundationDayTShirtDistributions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,StudentID,TokenNumber,TShirtSize,QRCode")] FoundationDayTShirtDistribution foundationDayTShirtDistribution)
        {
            if (ModelState.IsValid)
            {
                string str = foundationDayTShirtDistribution.QRCode;
                string[] id_num_size = str.Split('"');

                foundationDayTShirtDistribution.StudentID = id_num_size[3];
                foundationDayTShirtDistribution.TokenNumber = id_num_size[7];
                foundationDayTShirtDistribution.TShirtSize = id_num_size[11];

                db.FoundationDayTShirtDistributions.Add(foundationDayTShirtDistribution);

                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    //check for Exception type as sql Exception 
                    if (ex.GetBaseException().GetType() == typeof(SqlException))
                    {
                        ModelState.AddModelError("QRCode", "This StudentID is already exist");
                        return View(foundationDayTShirtDistribution);
                    }
                    else
                    {
                        ModelState.AddModelError("QRCode", "Something is wrong");
                        return View(foundationDayTShirtDistribution);
                    }
                }

                return RedirectToAction("Index");
            }

            return View(foundationDayTShirtDistribution);
        }

        // GET: FoundationDayTShirtDistributions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoundationDayTShirtDistribution foundationDayTShirtDistribution = db.FoundationDayTShirtDistributions.Find(id);
            if (foundationDayTShirtDistribution == null)
            {
                return HttpNotFound();
            }
            return View(foundationDayTShirtDistribution);
        }

        // POST: FoundationDayTShirtDistributions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,StudentID,TokenNumber,TShirtSize,QRCode")] FoundationDayTShirtDistribution foundationDayTShirtDistribution)
        {
            if (ModelState.IsValid)
            {
                db.Entry(foundationDayTShirtDistribution).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(foundationDayTShirtDistribution);
        }

        // GET: FoundationDayTShirtDistributions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoundationDayTShirtDistribution foundationDayTShirtDistribution = db.FoundationDayTShirtDistributions.Find(id);
            if (foundationDayTShirtDistribution == null)
            {
                return HttpNotFound();
            }
            return View(foundationDayTShirtDistribution);
        }

        // POST: FoundationDayTShirtDistributions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FoundationDayTShirtDistribution foundationDayTShirtDistribution = db.FoundationDayTShirtDistributions.Find(id);
            db.FoundationDayTShirtDistributions.Remove(foundationDayTShirtDistribution);
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
