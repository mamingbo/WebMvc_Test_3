using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPlat_Test_3.Util
{
    public class WebHelper
    {

        /// <summary>
        /// 获取链接上下文信息
        /// </summary>
        /// <param name="name">名称</param>
        /// <returns></returns>
        public static object GetHttpItems(string name)
        {
            if (HttpContext.Current == null)
            {
                return null;
            }
            return HttpContext.Current.Items[name];
        }

    }
}