using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MastersNet.Helpers
{
    public static class HtmlHelpers
    {
        public static MvcHtmlString Loader(this HtmlHelper html)
        {
            var img = new TagBuilder("img");
            img.Attributes.Add("src", "/Content/img/ajax-loader-10.gif");
            return new MvcHtmlString(img.ToString());
        }
    }
}