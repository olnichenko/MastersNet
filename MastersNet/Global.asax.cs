using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using FreeGeoIp;
using MastersNet.Helpers;

namespace MastersNet
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        void Session_Start(object sender, EventArgs e)
        {
            var ip = Request.UserHostAddress;
            //var ip = Request.ServerVariables["REMOTE_ADDR"];
            var ipInfoFactory = new IpInfoFactory(ip);
            var ipInfo = ipInfoFactory.LoadData();
            HttpContext.Current.Session[Constants.IpInfoSession] = ipInfo;
        }
    }
}
