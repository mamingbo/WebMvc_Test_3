using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPlat_Test_1
{
    public class Net
    {






 
        /// <summary>
        /// 获取浏览器信息
        /// </summary>
        public static string Browser
        {
            get
            {
                if (HttpContext.Current == null)
                    return string.Empty;
                var browser = HttpContext.Current.Request.Browser;
                return string.Format("{0} {1}", browser.Browser, browser.Version);
            }
        }
    }
}