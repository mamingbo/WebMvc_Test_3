using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPlat_Test_1
{
    public abstract class MvcControllerBase: Controller
    {

        protected virtual ActionResult Success(string info)
        {
            return Content(new ResParameter { code = ResponseCode.success, info = info, data = new object { } }.ToJson());
        }

        /// <summary>
        /// 返回失败消息
        /// </summary>
        /// <param name="info">消息</param>
        /// <param name="data">消息</param>
        /// <returns></returns>
        protected virtual ActionResult Fail(string info, object data)
        {
            return Content(new ResParameter { code = ResponseCode.fail, info = info, data = data }.ToJson());
        }
    }
}