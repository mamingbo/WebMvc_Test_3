using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebPlat_Test_3.Mod;

namespace WebPlat_Test_3.Util
{
    public class LoginUserInfo
    {
        /// <summary>
        /// 获取当前上下文执行用户信息
        /// </summary>
        /// <returns></returns>
        public static UserInfo_Mod Get()
        {
            return (UserInfo_Mod)HttpContext.Current.Items["LoginUserInfo"];
        }
    }
}