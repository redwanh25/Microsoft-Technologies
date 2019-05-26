using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BFWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getData();
            }
        }

        private void attachParameters(SqlCommand cmd, String parameterName, Control control)
        {
            if(control is TextBox && ((TextBox)control).Text != string.Empty)
            {
                SqlParameter parameter = new SqlParameter(parameterName, ((TextBox)control).Text);
                cmd.Parameters.Add(parameter);
            }
            else if (control is DropDownList && ((DropDownList)control).SelectedValue != "-1")
            {
                SqlParameter parameter = new SqlParameter(parameterName, ((DropDownList)control).SelectedValue);
                cmd.Parameters.Add(parameter);
            }
        }

        private void getData()
        {
            string cs = "data source = .; integrated security = SSPI; database = BestowersAppDatabase_Old";
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("Member_Proc", con);
                cmd.CommandType = CommandType.StoredProcedure;

                attachParameters(cmd, "@FirstName", FirstNameTextBox);
                attachParameters(cmd, "@LastName", LastNameTextBox);
                attachParameters(cmd, "@BatchID", BatchIDTextBox);
                attachParameters(cmd, "@CadetNo", CadetNoTextBox);
                attachParameters(cmd, "@HomeEmail", HomeEmailTextBox);
                attachParameters(cmd, "@HomePhone", HomePhoneTextBox);
                attachParameters(cmd, "@City", CityTextBox);
                attachParameters(cmd, "@State", StateTextBox);
                attachParameters(cmd, "@CountryID", CountryIDTextBox);

                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cs = "data source = .; integrated security = SSPI; database = BestowersAppDatabase_Old";
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("sortData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                
                SqlParameter parameter = new SqlParameter("@data", DropDownList1.SelectedValue);
                cmd.Parameters.Add(parameter);

                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            getData();
        }

    }
}