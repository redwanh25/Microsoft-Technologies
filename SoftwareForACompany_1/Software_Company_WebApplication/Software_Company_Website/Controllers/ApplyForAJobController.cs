using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Software_Company_Website.Models;

namespace Software_Company_Website.Controllers
{
    public class ApplyForAJobController : Controller
    {
        private ApplyForAJobDBEntities db = new ApplyForAJobDBEntities();

        // GET: ApplyForAJob/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApplyForAJob/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,PhoneNumber,Email,DataCV")] JobCVPdf_tbl jobCVPdf_tbl, HttpPostedFileBase pdf)
        {
            if (ModelState.IsValid)
            {
                Stream str = pdf.InputStream;
                BinaryReader Br = new BinaryReader(str);
                byte[] FileDet = Br.ReadBytes((Int32)str.Length);

                jobCVPdf_tbl.FileName = pdf.FileName;
                jobCVPdf_tbl.ContentType = pdf.ContentType;
                jobCVPdf_tbl.DataCV = FileDet;
                jobCVPdf_tbl.Date = DateTime.Now;

                db.JobCVPdf_tbl.Add(jobCVPdf_tbl);
                db.SaveChanges();
                return RedirectToAction("Create");
            }

            return View(jobCVPdf_tbl);
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
