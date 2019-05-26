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
    public partial class TemplateDetails : System.Web.UI.Page
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

                CIS.Lib.DALC.Organization r = new CIS.Lib.DALC.Organization();
                DataSet ds = r.Find(AppSetting.GetConnString(), "Organization", string.Empty, " ORDER BY Name");
                ddlOrganization.DataSource = ds.Tables[0].DefaultView;
                ddlOrganization.DataBind();

                if (id == 0)
                {
                    lblHeader.Text = "ADD TEMPLATE INFORMATION";
                    // wire the onclick event
                    btnDelete.Visible = false;

                }
                else
                {
                    lblHeader.Text = "UPDATE TEMPLATE INFORMATION";
                    LoadData(id);
                }

                if (AppSecurity.GetUserRole() != "1")
                {

                    btnCancel.Text = " OK ";
                    btnOK.Visible = false;
                    btnDelete.Visible = false;
                    tbTemplateName.Visible = false;
                    tbTemplateContent.Visible = false;
                    ddlOrganization.Visible = false;

                }
            }
        }

        protected void LoadData(int id)
        {

            CIS.Lib.DALC.Templates t = new CIS.Lib.DALC.Templates();
            t.Load(id);
            tbTemplateContent.Text = t.TemplateContent;
            tbTemplateName.Text = t.Name;
            foreach (ListItem li in ddlOrganization.Items)
            {
                if (t.OrganizationID == Convert.ToInt32(li.Value))
                    li.Selected = true;
            }

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            string templateName = tbTemplateName.Text;
            string templateContent = tbTemplateContent.Text;
            int organizationId = Convert.ToInt32(ddlOrganization.Text);
            // do the validation first			
            if (!ValidData())
            {
                lblMsg.Visible = true;
                return;
            }

            CIS.Lib.DALC.Templates t = new CIS.Lib.DALC.Templates();
            
            if (id == 0)
            {
                // insert 
                int tid = t.Insert(templateName, templateContent,organizationId);
                Response.Redirect("ListTemplates.aspx");

            }
            else
            {
                // Update 
                int newId = t.Update(id, templateName, templateContent,organizationId);
                Response.Redirect("ListTemplates.aspx");
            }



        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListTemplates.aspx");
        }

        private bool ValidData()
        {

            if (tbTemplateName.Text.Equals(""))
            {
                lblMsg.Text = "Template Name field is blank.";
                lblMsg.ForeColor = ColorTranslator.FromHtml("red");
                return false;
            }
            return true;
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            CIS.Lib.DALC.Templates t = new CIS.Lib.DALC.Templates();
            t.Delete(id);
            Response.Redirect("ListTemplates.aspx");
        }
    }
}
