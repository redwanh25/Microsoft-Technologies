﻿using System;
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
    public partial class DonationDetails : System.Web.UI.Page
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

                CIS.Lib.DALC.Donors d = new CIS.Lib.DALC.Donors();
                DataSet dsD = d.Find(AppSetting.GetConnString(),"Donors", string.Empty, " ORDER BY FullName");
                ddlDonor.DataSource = dsD.Tables[0].DefaultView;
                ddlDonor.DataBind();

                CIS.Lib.DALC.Tree t = new CIS.Lib.DALC.Tree();
                DataSet dsT = t.Find(AppSetting.GetConnString(), "Tree", string.Empty, " ORDER BY Name");
                ddlTree.DataSource = dsT.Tables[0].DefaultView;
                ddlTree.DataBind();
                // adding a new item for those that does not have tree
                //ddlTree.Items.Add(new ListItem("--", "0"));
                //ddlTree.SelectedValue = "0";
                ddlTree.Items.Insert(0, new ListItem("--", "0"));

                CIS.Lib.DALC.Fund f = new CIS.Lib.DALC.Fund();
                DataSet dsF = f.Find(AppSetting.GetConnString(), "Fund", string.Empty, " ORDER BY Name");
                ddlFund.DataSource = dsF.Tables[0].DefaultView;
                ddlFund.DataBind();
                ddlFund.Items.Insert(0, new ListItem("--", "0"));

                CIS.Lib.DALC.Organization o = new CIS.Lib.DALC.Organization();
                DataSet dsO = t.Find(AppSetting.GetConnString(), "Organization", string.Empty, " ORDER BY Name");
                ddlOrganization.DataSource = dsO.Tables[0].DefaultView;
                ddlOrganization.DataBind();

                if (id == 0)
                {
                    lblHeader.Text = "ADD DONATION INFORMATION";
                    // wire the onclick event
                    btnDelete.Visible = false;

                }
                else
                {
                    lblHeader.Text = "UPDATE DONATION INFORMATION";
                    LoadData(id);
                }

                if (AppSecurity.GetUserRole() != "1")
                {
                    btnCancel.Text = " OK ";
                    btnOK.Visible = false;
                    btnDelete.Visible = false;
                    tbAmount.Enabled = false;
                    tbDonationDate.Enabled = false;
                    tbDisplayName.Enabled = false;
                    tbPurpose.Enabled = false;
                    tbComments.Enabled = false;
                    ddlDonor.Enabled = false;
                    ddlFund.Enabled = false;
                    ddlTree.Enabled = false;
                    ddlOrganization.Enabled = false;
                    cbAnonymous.Enabled = false;

                }
            }
        }

        protected void LoadData(int id)
        {

            CIS.Lib.DALC.Donations d = new CIS.Lib.DALC.Donations();
            d.Load(id);

            tbAmount.Text = d.Amount.ToString();
            tbDonationDate.Text = d.DonationDate.ToString();
            tbDisplayName.Text = d.DisplayName;
            tbPurpose.Text = d.Purpose;
            tbComments.Text = d.Comments;

            if (d.Anonymous == true)
                cbAnonymous.Checked = true;


            foreach (ListItem li in ddlDonor.Items)
            {
                if (d.DonorID.ToString() == li.Value)
                    li.Selected = true;
            }
            foreach (ListItem li in ddlFund.Items)
            {
                if (d.FundID.ToString() == li.Value)
                    li.Selected = true;
            }
            foreach (ListItem li in ddlOrganization.Items)
            {
                if (d.OrganizationID.ToString() == li.Value)
                    li.Selected = true;
            }
            foreach (ListItem li in ddlTree.Items)
            {
                if (d.TreeID.ToString() == li.Value)
                    li.Selected = true;
            }
            

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {

            int donorId = Convert.ToInt32(ddlDonor.Text);

            double amount = Convert.ToDouble(tbAmount.Text);
            int fundId = Convert.ToInt32(ddlFund.SelectedValue);

            DateTime donationDate = Convert.ToDateTime(tbDonationDate.Text);

            string displayName = tbDisplayName.Text;

            bool anonymous = cbAnonymous.Checked;


            string purpose = tbPurpose.Text;

            string comments = tbComments.Text;

            int treeId = Convert.ToInt32(ddlTree.SelectedValue);

            int organizationId = Convert.ToInt32(ddlOrganization.SelectedValue);

            // do the validation first			
            if (!ValidData())
            {
                lblMsg.Visible = true;
                return;
            }

            CIS.Lib.DALC.Donations pu = new CIS.Lib.DALC.Donations();

            if (id == 0)
            {
                // insert 
                int uid = pu.Insert(donorId, amount, fundId, donationDate, displayName, anonymous, purpose, comments, treeId, organizationId);

                Response.Redirect("ListDonations.aspx");

            }
            else
            {
                // Update 
                int newId = pu.Update(id, donorId, amount, fundId, donationDate, displayName, anonymous, purpose, comments, treeId, organizationId);

                Response.Redirect("ListDonations.aspx");
            }



        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListDonations.aspx");
        }

        private bool ValidData()
        {

            if (tbAmount.Text.Equals(""))
            {
                lblMsg.Text = "Donation Amount field is blank.";
                lblMsg.ForeColor = ColorTranslator.FromHtml("red");
                return false;
            }
            return true;
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            CIS.Lib.DALC.Donations u = new CIS.Lib.DALC.Donations();
            u.Delete(id);
            Response.Redirect("ListDonations.aspx");
        }
    }
}
