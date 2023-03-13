using System.Web;
using System.Web.Mvc;

namespace PhamVanTri2080601252
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
