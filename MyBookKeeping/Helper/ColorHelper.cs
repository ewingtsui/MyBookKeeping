using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBookKeeping.Helper
{
    public static class ColorHelper
    {
        public static MvcHtmlString TypeColor(this HtmlHelper helper, string bookType)
        {
            string color;

            if (bookType == "0")
            {
                color = @"<span style='color:red'>支出</span>";
            }
            else
            {
                color = @"<span style='color:blue'>收入</span>";
            }

            return new MvcHtmlString(color);
        }
    }
}