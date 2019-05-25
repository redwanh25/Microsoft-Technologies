using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CIS.Lib.Utils;
using CIS.Lib.DALC;

namespace BFWeb
{
    public partial class TestingWebServices : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonFindMembers_Click(object sender, EventArgs e)
        {
            string strCol = DdlColumn.SelectedItem.Value;
            string strCriteria = TextBoxCriteria.Text;
            string strOrderBy = TextBoxOrderBy.Text;
            string strWhereClause = String.Empty;
            
            //CIS.Lib.Utils.Utility.WriteLog(string.Empty, strCol, "COLUMN NAME");
            //CIS.Lib.Utils.Utility.WriteLog(string.Empty, strCriteria, "CRITERIA");
            
            if ( (strCol == "Cadet No") && (strCriteria != ""))
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

            OrcaWebServices service = new OrcaWebServices();
            service.Url = AppSetting.GetServiceURLOrca();
            DataTable dt = service.GetOrcaMembers(strWhereClause, strOrderBy);
            GridViewOrcaMembers.DataSource = dt.DefaultView;
            GridViewOrcaMembers.DataBind();

        }

        protected void btnAuthenticateOrcans_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text;
            string password = tbPassword.Text;

            OrcaWebServices service = new OrcaWebServices();
            service.Url = AppSetting.GetServiceURLOrca();
            bool userExists = service.AuthenticateOrcans(userName, password);
            
            lblUserExists.Text = "Value Return from AutheticateOrcans service is: " + userExists.ToString();

        }

        protected void btnHelloWorld_Click(object sender, EventArgs e)
        {

            string userName = tbUserName.Text;
            string password = tbPassword.Text;

            OrcaWebServices service = new OrcaWebServices();
            service.Url = AppSetting.GetServiceURLOrca();
            string strMessage = service.HelloWorld(userName, password);

            lblUserExists.Text = "Value Return from Hello World service is: <br> " + strMessage;
        }
    }
}
