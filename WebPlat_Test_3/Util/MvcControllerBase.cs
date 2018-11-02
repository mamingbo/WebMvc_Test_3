using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPlat_Test_3.Mod;

namespace WebPlat_Test_3.Util
{
    public class MvcControllerBase:Controller
    {

        /// <summary>
        /// 返回成功消息
        /// </summary>
        /// <param name="info">消息</param>
        /// <returns></returns>
        protected virtual ActionResult Success(string info)
        {
            string sddd = new RevertPar_Mod { code = ERevertCode.success, info = info, data = new object { } }.ToJson();
            return Content(new RevertPar_Mod { code = ERevertCode.success, info = info, data = new object { } }.ToJson());
        }

        /// <summary>
        /// 返回成功数据
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns></returns>
        protected virtual ActionResult Success(object data)
        {
            return Content(new RevertPar_Mod { code = ERevertCode.success, info = "响应成功", data = data }.ToJson());
        }

        /// <summary>
        /// 返回失败消息
        /// </summary>
        /// <param name="info">消息</param>
        /// <param name="data">消息</param>
        /// <returns></returns>
        protected virtual ActionResult Fail(string info, object data)
        {
            return Content(new RevertPar_Mod { code = ERevertCode.fail, info = info, data = data }.ToJson());
        }


    }
}