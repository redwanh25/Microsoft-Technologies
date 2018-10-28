using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DELL-PC;Initial Catalog=demo;Integrated Security=True");
        using (SqlCommand cmd = new SqlCommand("spCheckUserCredentials", con))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", TextBox2.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Password"].ToString() == TextBox1.Text)
                {
                    Response.Redirect("Default2.aspx?User_name=" + TextBox2.Text);
                }
                else
                {
                    Label1.Text = "Invailid password and Username";
                }
            }
            else
            {
                Label1.Text = "Invailid password and Username";
            }
        }

    }
}