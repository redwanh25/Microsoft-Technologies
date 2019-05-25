using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CIS.Lib.DALC;


namespace BFWeb
{
    public partial class BestowerSoft : System.Web.UI.MasterPage
    {
        public int roleId = 3; // normal user
        public string pmsdMenu = string.Empty;
        public string orgId = "1";
        public string orgName = string.Empty;


        protected void Page_Load(object sender, EventArgs e)
        {

            // Populate Greatings label
            int userId = AppSecurity.GetUserID();
            // get organization id to load logo
            orgId = AppSecurity.GetUserOrganization();

            CIS.Lib.Utils.Utility.WriteLog(string.Empty, orgId, "Value of ORGID");

            CIS.Lib.DALC.Organization o = new CIS.Lib.DALC.Organization();
            o.Load(Convert.ToInt32(orgId));
            orgName = o.Name; 
            
            Page.Header.Title = "Bestower Accounting Software";
            pmsdMenu = GetMenuItems(Convert.ToInt32(AppSecurity.GetUserRole()), Convert.ToInt32(orgId));

           

            CIS.Lib.DALC.AppUser au = new CIS.Lib.DALC.AppUser();
            au.Load(userId);
            lblGreetings.Text = "Welcome, " + au.FirstName + " " + au.LastName;

        }

        protected string GetMenuItems(int roleId, int orgId)
        {
            string sMenu = string.Empty;

            switch (orgId)
            {
                // Manager
                case 1:
                    sMenu = @"        
                          <ul>         	
        	                <li><a href='BestowerSoft.aspx'>Home</a>
	                        <li><a href='ListDonations.aspx'>Donations</a>                     	
	                        <li><a href='ListExpenses.aspx'>Expenses</a>   
	                        <li><a href='ReportCenter.aspx'>Reports</a>   
	                        <li><a href='javascript:void(0)'>Configure</a>
	                        <ul>         	
		                        <li><a href='ListUsers.aspx'>Users</a>
		                        <li><a href='ListTemplates.aspx'>Templates</a>
		                        <li><a href='ListFunds.aspx'>Funds</a>
		                        <li><a href='RoleAdmin.aspx'>User Roles</a>
		                        <li><a href='ListExpenseCategories.aspx'>Expense Categories</a>
	                        </ul> 
                               <li><a href='javascript:void(0)'>Help</a>
	                        <ul> 
		                        <li><a href='AboutBestowerSoft.aspx'>About BestowerSoft</a>
		                        <li><a href='ContactTechSupport.aspx'>Tech Support</a>
	                        </ul>         	
	                        <li><a href='Logout.aspx'>Logout</a>
                         </ul>";
                    break;

                // Operator
                case 2:
                    sMenu = @"        
                          <ul>         	
        	                <li><a href='BestowerSoft.aspx'>Home</a>
	                        <li><a href='ListOrcaMembers.aspx'>Member Search</a>                     	
	                        <li><a href='ListDonations.aspx'>Donations</a>                     	
	                        <li><a href='ListExpenses.aspx'>Expenses</a>   
	                        <li><a href='ReportCenter.aspx'>Reports</a>   
	                        <li><a href='javascript:void(0)'>Configure</a>
	                        <ul>         	
		                        <li><a href='ListUsers.aspx'>Users</a>
		                        <li><a href='ListTemplates.aspx'>Templates</a>
		                        <li><a href='ListFunds.aspx'>Funds</a>
		                        <li><a href='RoleAdmin.aspx'>User Roles</a>
		                        <li><a href='ListExpenseCategories.aspx'>Expense Categories</a>
	                        </ul> 
                               <li><a href='javascript:void(0)'>Help</a>
	                        <ul> 
		                        <li><a href='AboutBestowerSoft.aspx'>About BestowerSoft</a>
		                        <li><a href='ContactTechSupport.aspx'>Tech Support</a>
	                        </ul>         	
	                        <li><a href='Logout.aspx'>Logout</a>
                         </ul>"; 
                        break;
                // Users
                default:
                        sMenu = @"        
                          <ul>         	
        	                <li><a href='BestowerSoft.aspx'>Home</a>
	                        <li><a href='ListDonations.aspx'>Donations</a>                     	
	                        <li><a href='ListExpenses.aspx'>Expenses</a>   
	                        <li><a href='ReportCenter.aspx'>Reports</a>   
	                        <li><a href='javascript:void(0)'>Configure</a>
	                        <ul>         	
		                        <li><a href='ListUsers.aspx'>Users</a>
		                        <li><a href='ListTemplates.aspx'>Templates</a>
		                        <li><a href='ListFunds.aspx'>Funds</a>
		                        <li><a href='RoleAdmin.aspx'>User Roles</a>
		                        <li><a href='ListExpenseCategories.aspx'>Expense Categories</a>
	                        </ul> 
                               <li><a href='javascript:void(0)'>Help</a>
	                        <ul> 
		                        <li><a href='AboutBestowerSoft.aspx'>About BestowerSoft</a>
		                        <li><a href='ContactTechSupport.aspx'>Tech Support</a>
	                        </ul>         	
	                        <li><a href='Logout.aspx'>Logout</a>
                         </ul>"; 
                    break;
            }

            return sMenu;
        }



    }
}
