using System.Web.Mvc;

namespace JavaScript_And_JQuery.Areas.JavaScript_Tutorial
{
    public class JavaScript_TutorialAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "JavaScript_Tutorial";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "JavaScript_Tutorial_default",
                "JavaScript_Tutorial/{controller}/{action}/{id}",
                new { Controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}