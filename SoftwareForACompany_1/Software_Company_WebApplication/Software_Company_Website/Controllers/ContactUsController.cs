using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Software_Company_Website.Models;

namespace Software_Company_Website.Controllers
{
    public class ContactUsController : Controller
    {
        private ContactUs_DBEntities db = new ContactUs_DBEntities();

        // GET: ContactUs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactUs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Phone_Number,Email,Address,Message,Date")] PersonMessage_tbl personMessage_tbl)
        {
            if (ModelState.IsValid)
            {
                db.PersonMessage_tbl.Add(personMessage_tbl);
                db.SaveChanges();
                return RedirectToAction("Create");
            }

            return View(personMessage_tbl);
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
