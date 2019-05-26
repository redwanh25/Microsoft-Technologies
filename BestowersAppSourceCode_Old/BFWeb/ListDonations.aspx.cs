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
    public partial class ListDonations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (!IsPostBack)
            {
                string whereClause = String.Empty;
                string strLimit = String.Empty;
                // string strLimit = " TOP 10 ";
                string orderByClause = " ORDER BY d1.DonationDate DESC ";
                string year = String.Empty;
                DateTime td = DateTime.Today;
                year = td.Year.ToString();
                tbYear.Text = year;
                whereClause = " Year(d1.DonationDate) = " + year;
                GetDonationsData(whereClause, orderByClause, strLimit);

                // wire the client side javascript fundtion so that user
                // can select or unselect all check boxes...
                cbToggleAll.Attributes["onclick"] = "javascript:toggleAllCheckboxes(this);";

            }
            
            
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("DonationDetails.aspx");
        }

        protected void btnGetDonations_Click(object sender, EventArgs e)
        {
            string whereClause = String.Empty;
            string strYear = tbYear.Text;
            string strLimit = String.Empty;
            string orderByClause = " ORDER BY d1.DonationDate DESC ";

            if ((strYear != String.Empty) || (strYear != ""))
            {
                whereClause = "Year(d1.DonationDate) = " + strYear;
            }

            GetDonationsData(whereClause, orderByClause, strLimit);

        }

        protected void GetDonationsData(string whereClause, string orderByClause, string strLimit)
        {
            
            // first ... clear the label to display errors/iformation
            lblTesting.Text = string.Empty;

            CIS.Lib.DALC.Donations d = new CIS.Lib.DALC.Donations();
            DataSet ds = d.Find(whereClause, orderByClause, strLimit);

            int rowCount = 0;
            string strDonationDate = string.Empty;
            

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                strDonationDate = ((DateTime)dr["DonationDate"]).ToShortDateString();
                dr["DonationDate"] = strDonationDate;
                //CIS.Lib.Utils.Utility.WriteLog(string.Empty, strDonationDate, "VALUE FROM strDonationDate");

                rowCount++;
                if ((rowCount % 2) == 0)
                {
                    dr["TRClass"] = "datacell";
                    
                    
                }
                else
                {
                    dr["TRClass"] = "datacell2";
                    
                }

                //CIS.Lib.Utils.Utility.WriteLog(string.Empty, dr["CDonationDate"].ToString(), "VALUE FROM DonationDate..");

            }

            
            repParent.DataSource = ds.Tables[0].DefaultView;
            
            repParent.DataBind();
        }

        protected string SendMails(DataTable dtDonors)
        {

            string donorEmail = string.Empty;
            string donorName = string.Empty;
            int errorCount = 0;
            string errorText = string.Empty;

            foreach (DataRow dr in dtDonors.Rows)
            {
                donorEmail = dr["DonorEmail"].ToString();
                donorName = dr["DonorName"].ToString();

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("reza.nabi@comcast.net");
                msg.To.Add(new MailAddress(donorEmail));
                msg.CC.Add(new MailAddress("reza.nabi@gmail.com"));
                msg.Subject = "Softwar Testing :: Donation Receipt from Bestower Foundation";
                msg.Body = @"  <html>
					   <body>
						 Dear " + donorName + @": <br>
                         Please find your donation receipt atached. <br>
                         This is a test message... please ignore.
                         Thank you.
					   </body>
					   </html>";

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

                    //lblTesting.Text = "Donation Receipt sent to " + donorName + " at " + donorEmail;                    

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


        protected void btnSendDonationReceipt_Click(object sender, EventArgs e)
        {

            string whereClause = String.Empty;
            string strYear = tbYear.Text;
            string strLimit = String.Empty;
            string orderByClause = " ORDER BY d1.DonationDate DESC ";

            if ((strYear != String.Empty) || (strYear != ""))
            {
                whereClause = "Year(d1.DonationDate) = " + strYear;
            }

            CIS.Lib.DALC.Donations d = new CIS.Lib.DALC.Donations();
            DataSet ds = d.Find(whereClause, orderByClause, strLimit);

            // Creat data table structure to send donation receipts

            //Create a data table structure having donor's name and email
            DataTable dtDonors = new DataTable();
            dtDonors.Columns.Add(new DataColumn("DonorID", System.Type.GetType("System.String")));
            dtDonors.Columns.Add(new DataColumn("DonorName", System.Type.GetType("System.String")));
            dtDonors.Columns.Add(new DataColumn("DonorEmail", System.Type.GetType("System.String")));


            int rowCount = 0;
            int cbCount = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                CheckBox chk = (CheckBox)repParent.Items[rowCount].FindControl("cbSendReceipt");

                if (chk != null)
                {
                    if (chk.Checked)
                    {                        
                        // add row to email data tables, which will be used later to send emails
                        dtDonors.Rows.Add(dr["DonorID"].ToString(),dr["DonorName"], dr["DonorEmail"]);
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

        } // end foreach
    }
}
