using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_ile_Ticari_Otomasyon_TEz
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
