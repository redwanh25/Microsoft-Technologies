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
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNet.Identity;

namespace DIU_CPC_BlueDivision.Controllers
{
    public class ContestContestantsController : Controller
    {
        private ContestAndContestantsEntities db = new ContestAndContestantsEntities();

        private string superAdmin = ConfigurationManager.AppSettings["SuperAdmin"].ToString();
        private string admin = ConfigurationManager.AppSettings["Admin"].ToString();
        private string student = ConfigurationManager.AppSettings["Student"].ToString();
        private string admin_1 = ConfigurationManager.AppSettings["Admin_1"].ToString();

        // GET: ContestContestants
        public ActionResult Index(int cTrackerId)
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

            var contestContestants = db.ContestContestants.Include(c => c.ContestantsTable).Where(per => per.ContestantsTable.ContestTrackerId == cTrackerId)
                .Include(c => c.ContestTable).Where(per => per.ContestTable.ContestTrackerId == cTrackerId);
            ViewBag.count = db.ContestantsTables.Where(per => per.ContestTrackerId == cTrackerId).Count();

            ContestClass contestClass = new ContestClass();
            contestClass.updateContestant(cTrackerId);

            ViewBag.contestTrackerId = cTrackerId;
            return View(contestContestants.ToList());
        }

        //[NonAction]
        //// GET: ContestContestants/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    ContestContestant contestContestant = db.ContestContestants.Find(id);
        //    if (contestContestant == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(contestContestant);
        //}

        //// GET: ContestContestants/Create
        //[NonAction]
        //public ActionResult Create()
        //{
        //    ViewBag.ContestantId = new SelectList(db.ContestantsTables, "Id", "ContestantsName");
        //    ViewBag.ContestId = new SelectList(db.ContestTables, "Id", "ContestName");
        //    return View();
        //}

        // POST: ContestContestants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost] [NonAction]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,ContestId,ContestantId,ContestTimeSolve,UpSolve")] ContestContestant contestContestant)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.ContestContestants.Add(contestContestant);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.ContestantId = new SelectList(db.ContestantsTables, "Id", "ContestantsName", contestContestant.ContestantId);
        //    ViewBag.ContestId = new SelectList(db.ContestTables, "Id", "ContestName", contestContestant.ContestId);
        //    return View(contestContestant);
        //}

        // GET: ContestContestants/Edit/5

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
            ContestContestant contestContestant = db.ContestContestants.Find(id);
            if (contestContestant == null)
            {
                return HttpNotFound();
            }
            ContestContestant concon = db.ContestContestants.FirstOrDefault(per => per.Id == id);
            ViewBag.ContestantId = new SelectList(db.ContestantsTables.Where(per => per.Id == concon.ContestantId), "Id", "ContestantsName", contestContestant.ContestantId);
            ViewBag.ContestId = new SelectList(db.ContestTables.Where(per => per.Id == concon.ContestId), "Id", "ContestName", contestContestant.ContestId);
            return View(contestContestant);
        }

        // POST: ContestContestants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ContestId,ContestantId,ContestTimeSolve,UpSolve")] ContestContestant contestContestant)
        {
            ContestClass contestClass = new ContestClass();
            contestContestant.ContestId = contestClass.contestId(contestContestant.Id);
            contestContestant.ContestantId = contestClass.contestantId(contestContestant.Id);
            int cTId = (int)db.ContestantsTables.FirstOrDefault(per => per.Id == contestContestant.ContestantId).ContestTrackerId;
            if (ModelState.IsValid)
            {
                db.Entry(contestContestant).State = EntityState.Modified;
                db.SaveChanges();
                //contestClass.updateContestant(cTrackerId);
                return RedirectToAction("Index", "ContestContestants", new { cTrackerId = cTId });
            }
            ViewBag.ContestantId = new SelectList(db.ContestantsTables.Where(per => per.Id == contestContestant.ContestantId), "Id", "ContestantsName", contestContestant.ContestantId);
            ViewBag.ContestId = new SelectList(db.ContestTables.Where(per => per.Id == contestContestant.ContestantId), "Id", "ContestName", contestContestant.ContestId);
            return View(contestContestant);
        }

        // GET: ContestContestants/Delete/5
        //[NonAction]
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    ContestContestant contestContestant = db.ContestContestants.Find(id);
        //    if (contestContestant == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(contestContestant);
        //}

        //// POST: ContestContestants/Delete/5
        //[HttpPost, ActionName("Delete")] [NonAction]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    ContestContestant contestContestant = db.ContestContestants.Find(id);
        //    db.ContestContestants.Remove(contestContestant);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public ActionResult InputFromExcelFile(int cTId, HttpPostedFileBase excelfile)
        {
            string path = Server.MapPath("~/Excel_Files/" + excelfile.FileName);
            try
            {               
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                excelfile.SaveAs(path);

                // read data from excel file

                using (SpreadsheetDocument spreadSheetDocument = SpreadsheetDocument.Open(path, false))
                {
                    WorkbookPart workbookPart = spreadSheetDocument.WorkbookPart;
                    IEnumerable<Sheet> sheets = spreadSheetDocument.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>();
                    string relationshipId = sheets.First().Id.Value;
                    WorksheetPart worksheetPart = (WorksheetPart)spreadSheetDocument.WorkbookPart.GetPartById(relationshipId);
                    Worksheet workSheet = worksheetPart.Worksheet;
                    SheetData sheetData = workSheet.GetFirstChild<SheetData>();
                    List<Row> rows = sheetData.Descendants<Row>().ToList();

                    for (int i = 0; i < rows.Count(); i++) //this will also include your header row...
                    {
                        //Problem problem = new Problem();
                        //problem.ProblemName = GetCellValue(spreadSheetDocument, rows[i].Descendants<Cell>().ElementAt(0));
                        //problem.ProblemLink = GetCellValue(spreadSheetDocument, rows[i].Descendants<Cell>().ElementAt(1));
                        //if (rows[i].Count() == 3)
                        //{
                        //    problem.Comment = GetCellValue(spreadSheetDocument, rows[i].Descendants<Cell>().ElementAt(2));
                        //}
                        //problem.BlueSheetId = blueSheetId;
                        ////problem.uploadFromWhere = "Excel_File";
                        //db.Problems.Add(problem);
                    }
                    db.SaveChanges();
                }
                System.IO.File.Delete(path);
            }
            catch (Exception)
            {
                System.IO.File.Delete(path);
            }

            return RedirectToAction("Index", "ContestContestants", new { cTrackerId = cTId });
        }

        public static string GetCellValue(SpreadsheetDocument document, Cell cell)
        {
            SharedStringTablePart stringTablePart = document.WorkbookPart.SharedStringTablePart;
            string value = cell.CellValue.InnerXml;

            if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
            {
                return stringTablePart.SharedStringTable.ChildElements[Int32.Parse(value)].InnerText;
            }
            else
            {
                return value;
            }
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
