using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Software_Company_WebApplication.Models;

namespace Software_Company_WebApplication.Controllers
{
    public class JobCVPdfController : Controller
    {
        private DBEntities_JobCVPdf db = new DBEntities_JobCVPdf();

        // GET: JobCVPdf
        public ActionResult Index()
        {
            List<JobCVPdf_tbl> list = db.JobCVPdf_tbl.ToList();
            list = list.OrderByDescending(it => it.id).ToList();
            return View(list);
        }

        // GET: JobCVPdf/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobCVPdf_tbl jobCVPdf_tbl = db.JobCVPdf_tbl.Find(id);
            if (jobCVPdf_tbl == null)
            {
                return HttpNotFound();
            }
            byte[] byteArray = GetPdfFromDB(id);
            MemoryStream pdfStream = new MemoryStream();
            pdfStream.Write(byteArray, 0, byteArray.Length);
            pdfStream.Position = 0;
            return new FileStreamResult(pdfStream, "application/pdf");
            //return View(jobCVPdf_tbl);
        }

        //// GET: JobCVPdf/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    JobCVPdf_tbl jobCVPdf_tbl = db.JobCVPdf_tbl.Find(id);
        //    if (jobCVPdf_tbl == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(jobCVPdf_tbl);
        //}

        //// POST: JobCVPdf/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    JobCVPdf_tbl jobCVPdf_tbl = db.JobCVPdf_tbl.Find(id);
        //    db.JobCVPdf_tbl.Remove(jobCVPdf_tbl);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public ActionResult Delete(int id)
        {
            JobCVPdf_tbl jobCVPdf_tbl = db.JobCVPdf_tbl.Find(id);
            db.JobCVPdf_tbl.Remove(jobCVPdf_tbl);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DisplayPDF()
        {
            byte[] byteArray = GetPdfFromDB(4);
            MemoryStream pdfStream = new MemoryStream();
            pdfStream.Write(byteArray, 0, byteArray.Length);
            pdfStream.Position = 0;
            return new FileStreamResult(pdfStream, "application/pdf");
        }

        private byte[] GetPdfFromDB(int? id)
        {
            #region
            byte[] bytes = { };
            string constr = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT DataCV FROM JobCVPdf_tbl WHERE id=@Id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.HasRows == true)
                        {
                            sdr.Read();
                            bytes = (byte[])sdr["DataCV"];
                        }
                    }
                    con.Close();
                }
            }

            return bytes;
            #endregion
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
