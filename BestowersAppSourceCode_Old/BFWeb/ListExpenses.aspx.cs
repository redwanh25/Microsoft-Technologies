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
    public partial class ListExpenses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                string whereClause = String.Empty;
                string strLimit = String.Empty;
                // string strLimit = " TOP 10 ";
                string orderByClause = " ORDER BY e.ExpenseDate DESC ";
                DateTime td = DateTime.Today;
                string year = td.Year.ToString();
                whereClause = " Year(e.ExpenseDate) = " + year;
                tbYear.Text = year;

                GetExpensesData(whereClause, orderByClause, strLimit);

            }
            
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("ExpenseDetails.aspx");
        }

       
        protected void GetExpensesData(string whereClause, string orderByClause, string strLimit)
        {

            CIS.Lib.DALC.Expenses d = new CIS.Lib.DALC.Expenses();
            DataSet ds = d.Find(whereClause, orderByClause, strLimit);

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
            }
            repParent.DataSource = ds.Tables[0].DefaultView;
            repParent.DataBind();
        }

        protected void btnGetExepenses_Click(object sender, EventArgs e)
        {
            string whereClause = String.Empty;
            string strYear = tbYear.Text;
            string strLimit = String.Empty;
            string orderByClause = " ORDER BY e.ExpenseDate DESC ";

            if ((strYear != String.Empty) || (strYear != ""))
            {
                whereClause = "Year(e.ExpenseDate) = " + strYear;
            }

            GetExpensesData(whereClause, orderByClause, strLimit);

        }

    }
}
