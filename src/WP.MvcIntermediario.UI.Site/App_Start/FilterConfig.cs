using System.Web;
using System.Web.Mvc;
using WP.MvcIntermediario.Infra.CrossCrutting.AspNetFilters;

namespace WP.MvcIntermediario.UI.Site
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new GlobalActionLogger());
        }
    }
}
