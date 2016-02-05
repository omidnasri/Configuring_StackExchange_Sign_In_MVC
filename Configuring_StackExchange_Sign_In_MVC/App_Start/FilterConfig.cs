using System.Web;
using System.Web.Mvc;

namespace Configuring_StackExchange_Sign_In_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
