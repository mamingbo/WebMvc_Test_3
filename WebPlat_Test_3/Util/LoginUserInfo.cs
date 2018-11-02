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
        //public static UserInfo_Mod Get()
        //{
        //    return (UserInfo_Mod)HttpContext.Current.Items["LoginUserInfo"];
        //}

        public static UserInfo_Mod Get()
        {
            UserInfo_Mod info = new UserInfo_Mod();
            info.account = "System";
            info.appId = "Learun_ADMS_6.1_PC";
            info.browser = "InternetExplorer 11.0";
            info.companyId = "";
            info.departmentId = "";
            info.enCode = "System";
            info.gender = 1;
            info.headIcon = "/Resource/PhotoFile/System.jpg";
            info.iPAddress = "192.168.56.1";
            info.isSystem = true;
            info.logTime =DateTime.Now;
            info.loginMark = "16f2a703-c462-41c5-9070-ad5d7dbe00d8";
            info.realName = "超级管理员";
            info.secretkey = "cb0d8213f3d570c8";
            info.token = "31800b8a-3478-445a-9e05-7a2d5b03f729";
            info.userId = "System";
       


            return info;

        }
    }
}