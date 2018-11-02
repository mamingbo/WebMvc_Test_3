using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace WebPlat_Test_3.Util
{

    [AttributeUsage(AttributeTargets.Method)]
    public class AjaxYZ : ActionMethodSelectorAttribute
    {
        /// <summary>
        /// 初始化仅允许Ajax操作
        /// </summary>
        /// <param name="ignore">跳过Ajax检测</param>
        public AjaxYZ(bool ignore = false)
        {
            Ignore = ignore;
        }

        /// <summary>
        /// 跳过Ajax检测
        /// </summary>
        public bool Ignore { get; set; }

        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            if (Ignore)
            {
                return true;
            }    
            return controllerContext.RequestContext.HttpContext.Request.IsAjaxRequest();
        }
    }
}