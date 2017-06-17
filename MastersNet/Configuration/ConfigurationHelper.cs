using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MastersNet.Configuration
{
    public class ConfigurationHelper
    {
        public static string FacebookAppId
        {
            get { return ConfigurationManager.AppSettings["FacebookAppId"]; }
        }

        public static string FacebookAppSecret
        {
            get { return ConfigurationManager.AppSettings["FacebookAppSecret"]; }
        }
    }
}