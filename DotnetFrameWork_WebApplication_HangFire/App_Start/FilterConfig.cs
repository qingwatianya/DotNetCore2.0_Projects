using System.Web;
using System.Web.Mvc;

namespace DotnetFrameWork_WebApplication_HangFire
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
