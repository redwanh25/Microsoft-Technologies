using System.Web;
using System.Web.Mvc;

namespace DIU_CPC_BlueDivision
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
