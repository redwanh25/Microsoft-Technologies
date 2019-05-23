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
    public class ContestantsTablesController : Controller
    {
        private ContestAndContestantsEntities db = new ContestAndContestantsEntities();

        private string superAdmin = ConfigurationManager.AppSettings["SuperAdmin"].ToString();
        private string admin = ConfigurationManager.AppSettings["Admin"].ToString();
        private string student = ConfigurationManager.AppSettings["Student"].ToString();
        private string admin_1 = ConfigurationManager.AppSettings["Admin_1"].ToString();

        // GET: ContestantsTables
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

            List<ContestantsTable> list = db.ContestantsTables.Where(per => per.ContestTrackerId == cTrackerId).ToList();
            return View(list);
        }

        // GET: ContestantsTables/Details/5
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
            ContestantsTable contestantsTable = db.ContestantsTables.Find(id);
            if (contestantsTable == null)
            {
                return HttpNotFound();
            }
            return View(contestantsTable);
        }

        // GET: ContestantsTables/Create
        public ActionResult Create(int ContestTrackerId)
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

            ViewBag.ContestTrackerId = new SelectList(db.ContestTrackers.Where(per => per.Id == ContestTrackerId), "Id", "ContestYear");
            return View();
        }

        // POST: ContestantsTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ContestantsName,StudentId,CFHandle,CFHandleLink,ContestTrackerId")] ContestantsTable contestantsTable)        // ,Score,TotalSolve,TotalParticipation,OnlineParticipation,SolveCountOnsite,SolveCountUpsolves,AverageSolvePerContest
        {
            if (ModelState.IsValid)
            {
                db.ContestantsTables.Add(contestantsTable);
                db.SaveChanges();
                return RedirectToAction("Index", "ContestantsTables", new { cTrackerId = contestantsTable.ContestTrackerId });
            }
            ViewBag.ContestTrackerId = new SelectList(db.ContestTrackers.Where(per => per.Id == contestantsTable.ContestTrackerId), "Id", "ContestYear");
            return View(contestantsTable);
        }

        // GET: ContestantsTables/Edit/5
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
            ContestantsTable contestantsTable = db.ContestantsTables.Find(id);
            if (contestantsTable == null)
            {
                return HttpNotFound();
            }
            ContestantsTable contestantsTable1 = db.ContestantsTables.FirstOrDefault(per => per.Id == id);
            ViewBag.ContestTrackerId = new SelectList(db.ContestTrackers.Where(per => per.Id == contestantsTable1.ContestTrackerId), "Id", "ContestYear");
            return View(contestantsTable);
        }

        // POST: ContestantsTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ContestantsName,StudentId,CFHandle,CFHandleLink,Score,TotalSolve,TotalParticipation,OnlineParticipation,SolveCountOnsite,SolveCountUpsolves,AverageSolvePerContest,ContestTrackerId")] ContestantsTable contestantsTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contestantsTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "ContestantsTables", new { cTrackerId = contestantsTable.ContestTrackerId });
            }
            ViewBag.ContestTrackerId = new SelectList(db.ContestTrackers.Where(per => per.Id == contestantsTable.ContestTrackerId), "Id", "ContestYear");
            return View(contestantsTable);
        }

        // GET: ContestantsTables/Delete/5
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
            DeleteDataFromDatabase deleteDataFromDatabase = new DeleteDataFromDatabase();
            deleteDataFromDatabase.deleteContestant(id);

            ContestantsTable contestantsTable = db.ContestantsTables.Find(id);
            int cTId = (int)contestantsTable.ContestTrackerId;
            db.ContestantsTables.Remove(contestantsTable);
            db.SaveChanges();
            return RedirectToAction("Index", "ContestantsTables", new { cTrackerId = cTId });
        }

        [HttpPost]
        public ActionResult InputFromExcelFile(int cTId, HttpPostedFileBase excelfile)
        {
            string path = Server.MapPath("~/Excel_Files/" + excelfile.FileName);
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

                for (int col = 5; col < rows[3].Count(); col++)         // start with 0 index
                {
                    ContestantsTable contestantsTable = new ContestantsTable();
                    try
                    {
                        string studentId = GetCellValue(spreadSheetDocument, rows[3].Descendants<Cell>().ElementAt(col));
                        string contestantsName = GetCellValue(spreadSheetDocument, rows[4].Descendants<Cell>().ElementAt(col));
                        string cFHandle = GetCellValue(spreadSheetDocument, rows[5].Descendants<Cell>().ElementAt(col));

                        contestantsTable.ContestantsName = contestantsName;
                        contestantsTable.StudentId = studentId;
                        contestantsTable.CFHandle = cFHandle;
                        contestantsTable.ContestTrackerId = cTId;

                        db.ContestantsTables.Add(contestantsTable);
                    }
                    catch (Exception)
                    {
                        //break;
                    }
                }
                db.SaveChanges();
            }
            System.IO.File.Delete(path);

            return RedirectToAction("Index", "ContestantsTables", new { cTrackerId = cTId });
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
