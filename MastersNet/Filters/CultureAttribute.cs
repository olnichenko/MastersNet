using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace MastersNet.Filters
{
    public class CultureAttribute: FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //throw new NotImplementedException();
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            // Получаем куки из контекста, которые могут содержать установленную культуру
            var cultureCookie = filterContext.HttpContext.Request.Cookies["lang"];
            string cultureName;
            if (cultureCookie == null)
            {
                cultureName = GetDefaultCulture(Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName);
            }
            else
            {
                cultureName = cultureCookie.Value;
            }
            

            // Список культур
            var cultures = new List<string> {"ru", "en"};
            if (!cultures.Contains(cultureName))
            {
                cultureName = "en";
            }
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureName);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(cultureName);
        }

        private string GetDefaultCulture(string cultureDisplayName)
        {
            var ruCulturies = new [] { "ab", "av", "uk", "ru", "ba", "be", "ka", "kk", "ky", "kv", "os", "tg", "tt", "uz", "cu", "ce", "cv" };
            if (ruCulturies.Contains(cultureDisplayName))
            {
                return "ru";
            }
            return "en";
        }
    }
}