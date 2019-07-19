using System.Web.Mvc;

namespace JavaScript_And_JQuery.Areas.JQuery_Tutorial
{
    public class JQuery_TutorialAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "JQuery_Tutorial";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "JQuery_Tutorial_default",
                "JQuery_Tutorial/{controller}/{action}/{id}",
                new { Controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}