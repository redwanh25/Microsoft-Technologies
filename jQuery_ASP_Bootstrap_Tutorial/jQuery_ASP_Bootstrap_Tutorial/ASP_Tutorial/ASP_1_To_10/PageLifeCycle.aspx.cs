using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace jQuery_ASP_Bootstrap_Tutorial.ASP_Tutorial.ASP_1_To_10
{
    public partial class PageLifeCycle : System.Web.UI.Page
    {
        // aita kintu akta webform create korar shomoy e thake. but, nicher gula thake na...
        // so, amra akhun code ta run kore dekhbo kontar pore konta automatic run hoy

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page_Load **" + "<br/>");
        }

        // start
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page_PreInit" + "<br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page_Init" + "<br/>");
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Page_InitComplete" + "<br/>");
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("Page_PreLoad" + "<br/>");
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("Page_LoadComplete" + "<br/>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page_PreRender" + "<br/>");
        }
        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write("Page_PreRenderComplete" + "<br/>");
        }
        protected void Page_Unload(object sender, EventArgs e)
        {
            // er moddeh kono kisu print kora jabe na. print korle e error dibe. cs, page to load e hoyni. 2mi kmne output dekhba..?
            // Response.Write("Page_Unload" + "<br/>");
        }
    }
}