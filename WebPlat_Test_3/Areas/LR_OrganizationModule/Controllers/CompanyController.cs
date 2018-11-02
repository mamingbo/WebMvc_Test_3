using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPlat_Test_3.Util;
using WebPlat_Test_3.Bll.LR_OrganizationModule;

namespace WebPlat_Test_3.Areas.LR_OrganizationModule.Controllers
{
    public class CompanyController : MvcControllerBase
    {
        // GET: LR_OrganizationModule/Company

        private Company_Bll Companybll = new Company_Bll();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// 表单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Form()
        {
            return View();
        }


        /// <summary>
        /// 获取公司列表信息
        /// </summary>
        /// <param name="keyword">查询关键字</param>
        /// <returns></returns>
        [HttpGet]
        [AjaxYZ]
        public ActionResult GetList(string keyword)
        {
            var data = Companybll.GetList();
            return Success(data);
        }
    }
}