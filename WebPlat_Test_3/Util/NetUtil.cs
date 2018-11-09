using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPlat_Test_3.Util
{
    public class NetUtil
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

                //string temp = "InternetExplorer 11.0";
                //return temp;
                string svvv = string.Format("{0} {1}", browser.Browser, browser.Version);
                return string.Format("{0} {1}", browser.Browser, browser.Version);
            }
        }
    }
}