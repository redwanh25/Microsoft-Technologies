using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=DELL-PC;Initial Catalog=demo;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = ParentCommentIDAcess.GetAllDepartmentsandEmployee();
        GridView1.DataBind();
    }
    protected void btnCommentPublish_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("spCommentInsert", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@UserName", Request.QueryString["User_name"].ToString());
        cmd.Parameters.AddWithValue("@CommanetMessage", textComment.Text);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        GridView1.DataSource = ParentCommentIDAcess.GetAllDepartmentsandEmployee();
        GridView1.DataBind();
    }
    protected void btnReplyParent_Click(object sender, EventArgs e)
    {
        GridViewRow row = (sender as Button).NamingContainer as GridViewRow;
        Label lblchildCommentid = (Label)row.FindControl("lb1COmmenId");
        TextBox txtCommentParent = (TextBox)row.FindControl("textCommentReplyParent");
        SqlCommand cmd = new SqlCommand("spCommentReplyInsert", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@UserName", Request.QueryString["User_name"].ToString());
        cmd.Parameters.AddWithValue("@CommentMessage", txtCommentParent.Text);
        cmd.Parameters.AddWithValue("@ParentCommentID", lblchildCommentid.Text);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        GridView1.DataSource = ParentCommentIDAcess.GetAllDepartmentsandEmployee();
        GridView1.DataBind();

    }
}