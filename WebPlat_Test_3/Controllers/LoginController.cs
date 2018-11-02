using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPlat_Test_3.Util;

namespace WebPlat_Test_3.Controllers
{
    public class LoginController : MvcControllerBase
    {
        // GET: Login


        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        [HttpPost]
        [AjaxYZ]
        public ActionResult CheckLogin(string username, string password, string verifycode)
        {

            if(username =="1" && password =="1")
            {
                return Success("登录成功");
            }
            else
            {
                return Fail("登录出错", 0);
            }
     
     

        }

        /// <summary>
        /// 获取用户登录信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AjaxYZ]
        public ActionResult GetUserInfo()
        {
            var data = LoginUserInfo.Get();
            data.password = null;
            data.secretkey = null;

            return Success(data);
        }
    }
}