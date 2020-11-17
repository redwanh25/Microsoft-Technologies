using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrystalReportsProject.Report
{
    public partial class ReportViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        public void LoadReport()
        {
            var reportParam = (dynamic) Session["ReportParam"];
            ReportDocument reportDocument = new ReportDocument();
            string path = Server.MapPath("~/CrystalReports/" + reportParam.RptFileName);
            var dataSource = reportParam.DataSoure;
            reportDocument.Load(path);
            reportDocument.SetDataSource(dataSource);
            reportDocument.SetParameterValue("@rptName", reportParam.ReportTitle);
            CrystalReportViewer.ReportSource = reportDocument;
        }
    }
}