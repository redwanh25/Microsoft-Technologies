using DIU_CPC_BlueDivision.DatabaseConnection;
using DIU_CPC_BlueDivision.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DIU_CPC_BlueDivision.Controllers
{
    public class ContestSheetExcelFormatViewController : Controller
    {
        // GET: ContestSheetExcelFormatView
        public ActionResult Index(int cTrackerId)
        {
            ContestClass contestClass = new ContestClass();
            contestClass.updateContestant(cTrackerId);

            ContestAndContestantsEntities db = new ContestAndContestantsEntities();
            Contest_Contestants_ContestContestant ccc = new Contest_Contestants_ContestContestant();
            ccc.contestTables = db.ContestTables.Where(per => per.ContestTrackerId == cTrackerId).ToList();
            ccc.contestantsTables = db.ContestantsTables.Where(per => per.ContestTrackerId == cTrackerId).ToList();
            ccc.contestContestants = db.ContestContestants.ToList();
            return View(ccc);
        }
    }
}