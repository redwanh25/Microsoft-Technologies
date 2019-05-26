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
    public partial class ListOrcaMembers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                

            }
        }


        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrcaMemberDetails.aspx");
        }

        protected void btnSearchOrcaMembers_Click(object sender, EventArgs e)
        {
            string strCol = DdlColumn.SelectedItem.Value;
            string strCriteria = TextBoxCriteria.Text;
            string strWhereClause = String.Empty;
            string strOrderBy = string.Empty;

            //CIS.Lib.Utils.Utility.WriteLog(string.Empty, strCol, "COLUMN NAME");
            //CIS.Lib.Utils.Utility.WriteLog(string.Empty, strCriteria, "CRITERIA");

            if ((strCol == "Cadet No") && (strCriteria != ""))
            {
                strWhereClause = " m.CadetNo = " + strCriteria;

            }

            if ((strCol == "Batch No") && (strCriteria != ""))
            {
                strWhereClause = " m.BatchID = " + strCriteria;

            }


            if ((strCol == "First Name") && (strCriteria != ""))
            {
                strWhereClause = " m.FirstName LIKE '" + strCriteria + "%'";

            }
            if ((strCol == "Last Name") && (strCriteria != ""))
            {
                strWhereClause = " m.LastName LIKE '" + strCriteria + "%'";

            }
            if ((strCol == "City") && (strCriteria != ""))
            {
                strWhereClause = " m.City LIKE '" + strCriteria + "%'";

            }
            if ((strCol == "State") && (strCriteria != ""))
            {
                strWhereClause = " m.State = '" + strCriteria + "'";

            }
            if ((strCol == "Country") && (strCriteria != ""))
            {
                strWhereClause = " m.CountryID = '" + strCriteria + "'";

            }

            // Get orca members and fetch          
            GetOrcaMemberData(strWhereClause, strOrderBy);

        }

        protected void GetOrcaMemberData(string whereClause, string orderByClause)
        {


            CIS.Lib.DALC.AppUser au = new CIS.Lib.DALC.AppUser();
            DataSet ds = au.SearchOrcaMembers(whereClause, orderByClause);

            int rowCount = 0;


            foreach (DataRow dr in ds.Tables[0].Rows)
            {

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
