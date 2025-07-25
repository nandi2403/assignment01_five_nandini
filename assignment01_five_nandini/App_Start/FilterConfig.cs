using System.Web;
using System.Web.Mvc;

namespace assignment01_five_nandini
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
