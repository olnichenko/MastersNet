using System.Web;
using System.Web.Mvc;
using MastersNet.Filters;

namespace MastersNet
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new CultureAttribute());
        }
    }
}
