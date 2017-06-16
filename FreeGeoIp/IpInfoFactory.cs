using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FreeGeoIp.Models;
using Newtonsoft.Json;

namespace FreeGeoIp
{
    public class IpInfoFactory
    {
        private readonly string _ip;
        private string _url = "http://freegeoip.net/json/";
        public IpInfoFactory(string ip)
        {
            _ip = ip;
        }

        public IpInfo LoadData()
        {
            var ipInfo = new IpInfo();
            try
            {
                var info = new WebClient().DownloadString(_url + _ip);
                ipInfo = JsonConvert.DeserializeObject<IpInfo>(info);
            }
            catch (Exception e) { }
            return ipInfo;
        }
    }
}
