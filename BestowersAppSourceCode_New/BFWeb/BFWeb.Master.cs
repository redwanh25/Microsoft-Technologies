using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BFWeb
{
    public partial class BFWeb : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Header.Title = "Bestower Foundation";
            string sLinkFooter = string.Empty;
            string sLinkHeader = string.Empty;

            sLinkFooter = "<a href='PrivacyPolicy.aspx'>Privacy Policy</a>&nbsp;|&nbsp;";
            sLinkFooter = sLinkFooter + "<a href='TermsOfService.aspx'>Terms of Service</a>";

            sLinkHeader = "<a href='Default.aspx'>About Us</a>&nbsp;|&nbsp;";
            sLinkHeader = sLinkHeader + "<a href='JoinTheFoundation.aspx'>Join</a>&nbsp;|&nbsp;";
            sLinkHeader = sLinkHeader + "<a href='Services.aspx'>Community Services</a>&nbsp;|&nbsp;";
            sLinkHeader = sLinkHeader + "<a href='ApplicationForms.aspx'>Forms</a>&nbsp;|&nbsp;";
            sLinkHeader = sLinkHeader + "<a href='Grants.aspx'>Grants</a>&nbsp;|&nbsp;";
            sLinkHeader = sLinkHeader + "<a href='Scholarships.aspx'>Scholarship</a>&nbsp;|&nbsp;";
            sLinkHeader = sLinkHeader + "<a href='News.aspx'>News</a>&nbsp;|&nbsp;";
            sLinkHeader = sLinkHeader + "<a href='ContactUs.aspx'>Contact Us</a>&nbsp;|&nbsp;";
            if (Request.IsAuthenticated)
            {
                sLinkHeader = sLinkHeader + "<a href='Documents.aspx'>Documents</a>&nbsp;|&nbsp;";
                sLinkHeader = sLinkHeader + "<a href='Logout.aspx'>Logout</a>";
            }
            else
            {
                sLinkHeader = sLinkHeader + "<a href='Login.aspx'>Login</a>";
            }

            lblFooter.Text = sLinkFooter;
            lblHeader.Text = sLinkHeader;
        }
    }
}
