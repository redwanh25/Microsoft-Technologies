using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Drawing;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using CIS.Lib.DALC;
using CIS.Lib.Utils;

namespace BFWeb
{
    public partial class UserDetails : System.Web.UI.Page
    {
        int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["id"] != null)
            {
                id = Convert.ToInt32(Request.QueryString["id"]);
            }
            if (!IsPostBack)
            {
                btnDelete.Attributes["onclick"] = "javascript:return confirm('Are you sure you want to delete this record?')";

                CIS.Lib.DALC.UserRole r = new CIS.Lib.DALC.UserRole();
                DataSet ds = r.Find(AppSetting.GetConnString(), "Role", string.Empty, " ORDER BY Name");
                ddlRole.DataSource = ds.Tables[0].DefaultView;
                ddlRole.DataBind();

                if (id == 0)
                {
                    lblHeader.Text = "ADD USER INFORMATION";
                    // wire the onclick event
                    btnDelete.Visible = false;

                }
                else
                {
                    lblHeader.Text = "UPDATE USER INFORMATION";
                    LoadData(id);
                }

                if (AppSecurity.GetUserRole() != "1")
                {
                   
                    btnCancel.Text = " OK ";
                    btnOK.Visible = false;
                    btnDelete.Visible = false;
                    tbUserName.Enabled = false;
                    tbFirstName.Enabled = false;
                    tbLastName.Enabled = false;
                    tbEmail.Enabled = false;
                    tbPassword.Enabled = false;
                    ddlRole.Enabled = false;
                }
            }
        }

        protected void LoadData(int id)
        {

            CIS.Lib.DALC.AppUser u = new CIS.Lib.DALC.AppUser();
            u.Load(id);

            tbUserName.Text = u.UserName;
            tbFirstName.Text = u.FirstName;
            tbLastName.Text = u.LastName;
            tbEmail.Text = u.Email;
            tbPassword.Text = u.Password;
            foreach (ListItem li in ddlRole.Items)
            {
                if (u.Role == li.Value)
                    li.Selected = true;
            }

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {

            string username = tbUserName.Text;
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            string password = tbPassword.Text;
            string email = tbEmail.Text;
            int roleId = Convert.ToInt32(ddlRole.Text);

            // do the validation first			
            if (!ValidData())
            {
                lblMsg.Visible = true;
                return;
            }

            CIS.Lib.DALC.AppUser pu = new CIS.Lib.DALC.AppUser();

            if (id == 0)
            {
                // insert 
                int uid = pu.Insert(roleId, firstName, lastName, email, username, password);
                Response.Redirect("ListUsers.aspx");

            }
            else
            {
                // Update 
                int newId = pu.Update(id, roleId, firstName, lastName, email, username, password);
                Response.Redirect("ListUsers.aspx");
            }
            


        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListUsers.aspx");
        }

        private bool ValidData()
        {

            if (tbUserName.Text.Equals(""))
            {
                lblMsg.Text = "User Name field is blank.";
                lblMsg.ForeColor = ColorTranslator.FromHtml("red");
                return false;
            }
            return true;
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            CIS.Lib.DALC.AppUser u = new CIS.Lib.DALC.AppUser();
            u.Delete(id);
            Response.Redirect("ListUsers.aspx");
        }
    }
}
