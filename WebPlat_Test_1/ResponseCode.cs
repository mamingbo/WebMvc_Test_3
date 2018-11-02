using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPlat_Test_1
{
    public enum ResponseCode
    {
        /// <summary>
        /// 成功
        /// </summary>
        success = 200,
        /// <summary>
        /// 失败
        /// </summary>
        fail = 400,
        /// <summary>
        /// 异常
        /// </summary>
        exception = 500

    }
}