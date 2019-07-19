using System.Web;
using System.Web.Mvc;

namespace JavaScript_And_JQuery
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
