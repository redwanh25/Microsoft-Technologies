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

namespace BFWeb
{
    public partial class ListDonations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                string whereClause = "d1.OrganizationID = " + AppSecurity.GetUserOrganization();        
                string strLimit = String.Empty;
                // string strLimit = " TOP 10 ";
                string orderByClause = " ORDER BY d1.DonationDate DESC ";
                string year = String.Empty;
                DateTime td = DateTime.Today;
                year = td.Year.ToString();
                tbYear.Text = year;
                whereClause = whereClause + " AND Year(d1.DonationDate) = " + year;
                GetDonationsData(whereClause, orderByClause, strLimit);

            }


        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("DonationDetails.aspx");
        }

        protected void btnGetDonations_Click(object sender, EventArgs e)
        {
            string whereClause = "d1.OrganizationID = " + AppSecurity.GetUserOrganization();
            string strYear = tbYear.Text;
            string strLimit = String.Empty;
            string orderByClause = " ORDER BY d1.DonationDate DESC ";

            if ((strYear != String.Empty) || (strYear != ""))
            {
                whereClause = whereClause + " AND Year(d1.DonationDate) = " + strYear;
            }

            GetDonationsData(whereClause, orderByClause, strLimit);

        }

        protected void GetDonationsData(string whereClause, string orderByClause, string strLimit)
        {


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

    }
}
