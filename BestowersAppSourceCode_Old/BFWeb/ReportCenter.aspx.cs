using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using CIS.Lib.DALC;
using System.Net.Mail;

namespace BFWeb
{
    public partial class ReportCenter : System.Web.UI.Page
    {

        public string reportYear = string.Empty;
        public string strTotalIncomeAnnual = string.Empty;
        public string strTotalExpenseAnnual = string.Empty;
        public string strTotalIncomeStandard = string.Empty;
        public string strTotalExpenseStandard = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            // If first time loading...
            if (!IsPostBack)
            {
                panelAnnualReport.Visible = false;
                panelStandardReport.Visible = false;
                panelIncomeByDonors.Visible = false;

                DateTime td = DateTime.Today;                
                tbYear.Text = td.Year.ToString();

                // wire the client side javascript fundtion so that user
                // can select or unselect all check boxes...
                cbToggleAll.Attributes["onclick"] = "javascript:toggleAllCheckboxes(this);";
                cbToggleAllSimplified.Attributes["onclick"] = "javascript:toggleAllCheckboxes(this);";


            }
            
        }

        protected void btnGetReports_Click(object sender, EventArgs e)
        {

            // clear the message label
            lblTesting.Text = "";

            string reportName = ddlReportName.SelectedValue;
            string whereClauseIncome = String.Empty;
            string whereClauseExpense = String.Empty;
            string strYear = tbYear.Text;
            string orderByClause = " ORDER BY SumOfAmount DESC ";

            if ((strYear != String.Empty) || (strYear != ""))
            {
                // set where clause for to get income and expense data
                whereClauseIncome = "Year(Donations.DonationDate) = " + strYear;
                whereClauseExpense = "Year(Expenses.ExpenseDate) = " + strYear;
            }
            else
            {
                // Set the default year to current year
                DateTime td = DateTime.Today;
                strYear = td.Year.ToString();
                // set default where clause for to get income and expense data
                whereClauseIncome = "Year(Donations.DonationDate) = " + strYear;
                whereClauseExpense = "Year(Expenses.ExpenseDate) = " + strYear;

            }
            // Set the reportYear value which will be used in Annual Report Template
            reportYear = strYear;

            if (reportName.Equals("Annual"))
            {

                // Get the donation data and display to user 
                GetDonationsData(whereClauseIncome, orderByClause);

                // get the expense data and display to user
                GetExpenseData(whereClauseExpense, orderByClause);

                // calculate ending blance and display it
                double endingBalance = Convert.ToDouble(strTotalIncomeAnnual) - Convert.ToDouble(strTotalExpenseAnnual);
                lblEndingBalace.Text = string.Format("{0:0.00}", endingBalance);
                lblReportHeader.Text = "ANNUAL FINANCIAL REPORT " + reportYear;

                panelAnnualReport.Visible = true;
                panelStandardReport.Visible = false;
                panelIncomeByDonors.Visible = false;
                panelDonationsByDonorSimplified.Visible = false;

            }

            if (reportName.Equals("Standard"))
            {

                // Get the donation data and display to user 
                GetDonationsDataStandard(whereClauseIncome, orderByClause);

                // get the expense data and display to user
                GetExpenseDataStandard(whereClauseExpense, orderByClause);

                lblReportHeader.Text = "STANDARD INCOME AND EXPENSE REPORT " + reportYear;

                panelAnnualReport.Visible = false;
                panelStandardReport.Visible = true;
                panelIncomeByDonors.Visible = false;
                panelDonationsByDonorSimplified.Visible = false;

            }

            if (reportName.Equals("IncomeByDonors"))
            {

                // Get the donation data and display to user 
                GetDonationsDataByDonors(whereClauseIncome, orderByClause);
                lblReportHeader.Text = "INCOME BY DONORS REPORT " + reportYear;

                panelAnnualReport.Visible = false;
                panelStandardReport.Visible = false;
                panelIncomeByDonors.Visible = true;
                panelDonationsByDonorSimplified.Visible = false;

            }

            if (reportName.Equals("IncomeByDonorsSimplified"))
            {

                // Get the donation data and display to user 
                GetDonationsDataByDonorSimplified(whereClauseIncome, orderByClause);
                lblReportHeader.Text = "INCOME BY DONORS REPORT [SIMPLIFIED VERSION] " + reportYear;

                panelAnnualReport.Visible = false;
                panelStandardReport.Visible = false;
                panelIncomeByDonors.Visible = false;
                panelDonationsByDonorSimplified.Visible = true;

            }

            


        }

        protected void GetDonationsData(string whereClause, string orderByClause)
        {

            CIS.Lib.DALC.Donations d = new CIS.Lib.DALC.Donations();
            DataSet ds = d.FindDonationsByFund(whereClause, orderByClause);
            double totalIncome = 0;
            int rowCount = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                rowCount++;
                totalIncome = totalIncome + Convert.ToDouble(dr["SumOfAmount"]);
                // Update the SectionID column to hold value like 1.1, 1.2, 1.3 etc
                dr["SectionID"] = "1." + rowCount.ToString();
                // Update TRClass so it shows alternate color which is defined in CSS
                if ((rowCount % 2) == 0)
                {
                    dr["TRClass"] = "datacell";
                }
                else
                {
                    dr["TRClass"] = "datacell2";
                }
            }
            // Set total income value
            strTotalIncomeAnnual = String.Format("{0:0.00}", totalIncome); 
            
            // set data source of the repeater and bind/fetch data
            repParentDonationAnnualReport.DataSource = ds.Tables[0].DefaultView;
            repParentDonationAnnualReport.DataBind();
        
        }


        protected void GetExpenseData(string whereClause, string orderByClause)
        {

            CIS.Lib.DALC.Expenses exp = new CIS.Lib.DALC.Expenses();
            DataSet ds = exp.FindExpensesByFund(whereClause, orderByClause);
            double totalExpense = 0;
            int rowCount = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                rowCount++;
                totalExpense = totalExpense + Convert.ToDouble(dr["SumOfAmount"]);
                // Update the SectionID column to hold value like 1.1, 1.2, 1.3 etc
                dr["SectionID"] = "2." + rowCount.ToString();
                // Update TRClass so it shows alternate color which is defined in CSS
                if ((rowCount % 2) == 0)
                {
                    dr["TRClass"] = "datacell";
                }
                else
                {
                    dr["TRClass"] = "datacell2";
                }
            }
            // Set total income value
            strTotalExpenseAnnual = String.Format("{0:0.00}", totalExpense);

            // set data source of the repeater and bind/fetch data
            repParentExpenseAnnualReport.DataSource = ds.Tables[0].DefaultView;
            repParentExpenseAnnualReport.DataBind();

        }


        protected void GetDonationsDataStandard(string whereClause, string orderByClause)
        {

            CIS.Lib.DALC.Donations d = new CIS.Lib.DALC.Donations();
            DataSet ds = d.FindDonationsByFund(whereClause, orderByClause);
            double totalIncome = 0;
            int rowCount = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                rowCount++;
                totalIncome = totalIncome + Convert.ToDouble(dr["SumOfAmount"]);
                // Update the SectionID column to hold value like 1.1, 1.2, 1.3 etc
                dr["SectionID"] = "1." + rowCount.ToString();
                // Update TRClass so it shows alternate color which is defined in CSS
                if ((rowCount % 2) == 0)
                {
                    dr["TRClass"] = "datacell";
                }
                else
                {
                    dr["TRClass"] = "datacell2";
                }
            }
            // Set total income value
            strTotalIncomeStandard = String.Format("{0:0.00}", totalIncome);

            // set data source of the repeater and bind/fetch data
            repParentIncomeStandard.DataSource = ds.Tables[0].DefaultView;
            repParentIncomeStandard.DataBind();

        }


        protected void GetExpenseDataStandard(string whereClause, string orderByClause)
        {

            CIS.Lib.DALC.Expenses exp = new CIS.Lib.DALC.Expenses();
            DataSet ds = exp.FindExpensesByFund(whereClause, orderByClause);
            double totalExpense = 0;
            int rowCount = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                rowCount++;
                totalExpense = totalExpense + Convert.ToDouble(dr["SumOfAmount"]);
                // Update the SectionID column to hold value like 1.1, 1.2, 1.3 etc
                dr["SectionID"] = "2." + rowCount.ToString();
                // Update TRClass so it shows alternate color which is defined in CSS
                if ((rowCount % 2) == 0)
                {
                    dr["TRClass"] = "datacell";
                }
                else
                {
                    dr["TRClass"] = "datacell2";
                }
            }
            // Set total income value
            strTotalExpenseStandard = String.Format("{0:0.00}", totalExpense);

            // set data source of the repeater and bind/fetch data
            repParentExpenseStandard.DataSource = ds.Tables[0].DefaultView;
            repParentExpenseStandard.DataBind();

        }


        protected void GetDonationsDataByDonors(string whereClause, string orderByClause)
        {

            CIS.Lib.DALC.Donations d = new CIS.Lib.DALC.Donations();
            DataSet ds = d.GetDonationsByDonors(whereClause, orderByClause);
            double totalIncome = 0;
            int rowCount = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                rowCount++;
                totalIncome = totalIncome + Convert.ToDouble(dr["SumOfAmount"]);
                                
                // Update TRClass so it shows alternate color which is defined in CSS
                if ((rowCount % 2) == 0)
                {
                    dr["TRClass"] = "datacell";
                }
                else
                {
                    dr["TRClass"] = "datacell2";
                }
            }
            // Set total income value
            strTotalIncomeStandard = String.Format("{0:0.00}", totalIncome);

            // set data source of the repeater and bind/fetch data
            //repParentIncomeByDonors.DataSource = ds.Tables[0].DefaultView;
            repParentIncomeByDonors.DataSource = ds.Tables["parent"];
            repParentIncomeByDonors.DataBind();

        }

        protected DataView GetChildRelation(object dataItem, string relation)
        {
            DataRowView drv = dataItem as DataRowView;
            if (drv != null)
                return drv.CreateChildView(relation);
            else
                return null;
        }

        protected void GetDonationsDataByDonorSimplified(string whereClause, string orderByClause)
        {

            CIS.Lib.DALC.Donations d = new CIS.Lib.DALC.Donations();
            DataSet ds = d.GetDonationsByDonors(whereClause, orderByClause);
            double totalIncome = 0;
            int rowCount = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                rowCount++;
                totalIncome = totalIncome + Convert.ToDouble(dr["SumOfAmount"]);

                // Update TRClass so it shows alternate color which is defined in CSS
                if ((rowCount % 2) == 0)
                {
                    dr["TRClass"] = "datacell";
                }
                else
                {
                    dr["TRClass"] = "datacell2";
                }
            }
            // Set total income value
            strTotalIncomeStandard = String.Format("{0:0.00}", totalIncome);

            // set data source of the repeater and bind/fetch data
            repDonationByDonorSimplified.DataSource = ds.Tables["parent"];
            //ds.Tables[0].DefaultView;
            repDonationByDonorSimplified.DataBind();

        }

        protected void btnSendDonationReceipt_Click(object sender, EventArgs e)
        {
            string reportName = ddlReportName.SelectedValue;
            string whereClauseIncome = String.Empty;
            string whereClauseExpense = String.Empty;
            string strYear = tbYear.Text;
            string orderByClause = " ORDER BY SumOfAmount DESC ";

            if ((strYear != String.Empty) || (strYear != ""))
            {
                // set where clause for to get income 
                whereClauseIncome = "Year(Donations.DonationDate) = " + strYear;
            }

            //Create a data table structure having donor's name and email
            DataTable dtDonors = new DataTable();
            dtDonors.Columns.Add(new DataColumn("DonorID", System.Type.GetType("System.String")));
            dtDonors.Columns.Add(new DataColumn("DonorName", System.Type.GetType("System.String")));
            dtDonors.Columns.Add(new DataColumn("DonorEmail", System.Type.GetType("System.String")));
            dtDonors.Columns.Add(new DataColumn("DonationAmount", System.Type.GetType("System.String")));
            dtDonors.Columns.Add(new DataColumn("Criteria", System.Type.GetType("System.String")));


            
            DataSet ds = new DataSet();
            CIS.Lib.DALC.Donations d = new CIS.Lib.DALC.Donations();
            // Call different functions based on report name
            if (reportName.Equals("IncomeByDonors"))
            {
                // Get the data for incomes by donor            
                ds = d.GetDonationsByDonors(whereClauseIncome, orderByClause);
            }

            if (reportName.Equals("IncomeByDonorsSimplified"))
            {
                // Get the donation data and display to user 
                ds = d.FindDonationsByDonors(whereClauseIncome, orderByClause);                 
            }

            
            int rowCount = 0;
            int cbCount = 0;
            CheckBox chk = new CheckBox();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                // get the control based on the report name
                if (reportName.Equals("IncomeByDonors"))
                  chk = (CheckBox)repParentIncomeByDonors.Items[rowCount].FindControl("cbSendReceipt");

                if (reportName.Equals("IncomeByDonorsSimplified"))
                    chk = (CheckBox)repDonationByDonorSimplified.Items[rowCount].FindControl("cbSendReceiptSimplified");
                
                if (chk != null)
                {
                    if (chk.Checked)
                    {                        
                        // add row to email data tables, which will be used later to send emails
                        dtDonors.Rows.Add(dr["DonorID"].ToString(),dr["DonorName"], dr["DonorEmail"],dr["SumOfAmount"].ToString(), whereClauseIncome);
                        cbCount++;
                    }
                }               

                rowCount++;
            }

            // Check if any check boxes were checked....
            if (cbCount == 0)
            {
                lblTesting.Text = "Please check at least one check box on the right";
                return;
            }
            else
            {

                btnSendDonationReceipt.Attributes["onclick"] = "javascript:return confirm('Are you sure you want to send doantion receipts for all donations which are checked?')";
                
                string errorText = SendMails(dtDonors);                
                if (errorText.Equals("0"))
                {
                    lblTesting.Text = "Mail sent successful";

                }
                else
                {
                    lblTesting.Text = errorText;
                }
                
                return;

            }
        
        }
        
    protected string SendMails(DataTable dtDonors)
        {

            string donorEmail = string.Empty;
            string donorName = string.Empty;
            string donorId = string.Empty;
            string donationAmount = string.Empty;
            int errorCount = 0;
            string errorText = string.Empty;
            string today = DateTime.Today.ToShortDateString();
            string year = tbYear.Text;
            string whereClause = string.Empty;

            // get the donation receipts template from database for the organization
            int organizationId = Convert.ToInt32(AppSecurity.GetUserOrganization());
            CIS.Lib.DALC.Templates t = new CIS.Lib.DALC.Templates();
            string templateName = "Donation Receipt";
            t.Load(templateName, organizationId);

            

            foreach (DataRow dr in dtDonors.Rows)
            {
                donorId = dr["DonorID"].ToString();
                donorEmail = dr["DonorEmail"].ToString();
                donorName = dr["DonorName"].ToString();
                donationAmount = dr["DonationAmount"].ToString();
                whereClause = dr["Criteria"].ToString();
                
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("reza.nabi@comcast.net");
                msg.To.Add(new MailAddress(donorEmail));
                msg.CC.Add(new MailAddress("reza.nabi@gmail.com"));
                msg.Subject = "Donation Receipt from Bestower Foundation";

                // build body of the message

                string strBody = string.Empty;
                strBody = t.TemplateContent;
                strBody = strBody.Replace("zzzDatezzz", today);
                strBody = strBody.Replace("zzzDonorNamezzz", donorName);
                strBody = strBody.Replace("zzzDonationAmountzzz", donationAmount);
                strBody = strBody.Replace("zzzYearzzz", year);
                strBody = strBody.Replace("zzzDonationDetailszzz", string.Empty);


                msg.Body = strBody; 

                msg.IsBodyHtml = true;

                // SMTP Client
                SmtpClient client = new SmtpClient();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                // setup Smtp authentication
                System.Net.NetworkCredential credentials =
                    new System.Net.NetworkCredential("reza.nabi@gmail.com", "Mar2018!6224!");
                client.UseDefaultCredentials = false;
                client.Credentials = credentials;

                try
                {
                    // sent message
                    client.Send(msg);

                    // use this to update receiptsent date
                    CIS.Lib.DALC.Donations dn = new CIS.Lib.DALC.Donations();

                    dn.UpdateReceiptSentDate(Convert.ToInt32(donorId), Convert.ToDateTime(today), true, whereClause);

                                   

                }
                catch (Exception ex)
                {

                    //lblTesting.Text = "Error occured while sending your message." + ex.Message;
                    errorCount++;
                    // if first error happens initiate with donor's name 
                    // subsequent records... put comma to make a clean error list
                    if (errorCount == 1)
                    {
                        errorText = donorName;
                    }
                    else
                    {
                        errorText = errorText + ", " + donorName;
                    }

                }
            }

            // Return value based on error count...
            if (errorCount == 0)
            {
                return "0";
            }
            else
            {
                return "Failed to send receipts following donors: " + errorText;
            }

        }



    }
}
