using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using WebPlat_Test_3.Util;

namespace WebPlat_Test_3
{
    public static  class HtmlHelperExtensions
    {

        /// <summary>
        /// 往页面中写入js文件
        /// </summary>
        /// <param name="htmlHelper">需要扩展对象</param>
        /// <param name="jsFiles">文件路径</param>
        /// <returns></returns>
        public static MvcHtmlString AppendJsFile(this HtmlHelper htmlHelper, params string[] jsFiles)
        {
            string jsFile = "";
            foreach (string file in jsFiles)
            {
                if (jsFile != "")
                {
                    jsFile += ",";
                }
                jsFile += file;
            }
            string jsStr = JsHelper.ReadJSFile(jsFiles);

            StringBuilder content = new StringBuilder();
            string jsFormat = "<script>{0}</script>";

            content.AppendFormat(jsFormat, jsStr);
            return new MvcHtmlString(content.ToString());
        }

        /// <summary>
        /// 往页面中写入css样式
        /// </summary>
        /// <param name="htmlHelper">需要扩展对象</param>
        /// <param name="cssFiles">文件路径</param>
        /// <returns></returns>
        public static MvcHtmlString AppendCssFile(this HtmlHelper htmlHelper, params string[] cssFiles)
        {
            string cssFile = "";
            foreach (string file in cssFiles)
            {
                if (cssFile != "")
                {
                    cssFile += ",";
                }
                cssFile += file;
            }
            string cssStr = CssHelper.ReadCssFile(cssFiles);

      
            StringBuilder content = new StringBuilder();
            string cssFormat = "<style>{0}</style>";
            content.AppendFormat(cssFormat, cssStr);
            return new MvcHtmlString(content.ToString());
        }

        /// <summary>
        /// 设置当前页面地址
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <returns></returns>
        public static MvcHtmlString SetCurrentUrl(this HtmlHelper htmlHelper)
        {
            //  string currentUrl = (string)WebHelper.GetHttpItems("currentUrl");
            string currentUrl = "/LR_OrganizationModule/Company/Index";
            return new MvcHtmlString("<script>var lrCurrentUrl='" + currentUrl + "';var lrModuleButtonList;var lrModuleColumnList;var lrModule;</script>");
        }

    }
}