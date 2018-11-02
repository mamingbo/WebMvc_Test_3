using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPlat_Test_1.Controllers
{
    public class LoginController : MvcControllerBase
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [AjaxOnly]
        public ActionResult CheckLogin(string username, string password, string verifycode)
        {

            string passwordTemp = password;

            if (username == "1" && passwordTemp == password)
            {

                return Success("登录成功");
            }
            else
            {
                return Fail("账户或密码出错", 1);

            }



        }
    }
}