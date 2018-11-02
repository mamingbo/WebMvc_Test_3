
using System.Text;
using System.Web.Mvc;

namespace WebPlat_Test_1
{
    public static class HtmlHelperExtensions
    {



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
            string cssStr = JsCssHelper.ReadCssFile(cssFiles);

            StringBuilder content = new StringBuilder();
            string cssFormat = "<style>{0}</style>";
            content.AppendFormat(cssFormat, cssStr);
            return new MvcHtmlString(content.ToString());
        }

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
            string jsStr = JsCssHelper.ReadJSFile(jsFiles);

         

            StringBuilder content = new StringBuilder();
            string jsFormat = "<script>{0}</script>";

            content.AppendFormat(jsFormat, jsStr);
            return new MvcHtmlString(content.ToString());
        }

    }
}