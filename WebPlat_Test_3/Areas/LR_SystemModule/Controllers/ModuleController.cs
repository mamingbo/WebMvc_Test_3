using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPlat_Test_3.Util;
using WebPlat_Test_3.Bll.LR_SystemModule;
using WebPlat_Test_3.Mod;


namespace WebPlat_Test_3.Areas.LR_SystemModule.Controllers
{
    public class ModuleController : MvcControllerBase
    {

        private Model_Bll ModBll = new Model_Bll();


        // GET: LR_SystemModule/Module
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 获取功能模块数据列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AjaxYZ]
        public ActionResult GetModuleList()
        {
            var data = ModBll.GetModuleList();
            return this.Success(data);
        }

        /// <summary>
        /// 获取权限按钮和列表信息
        /// </summary>
        /// <param name="url">页面地址</param>
        /// <returns></returns>
        [HttpGet]
        [AjaxYZ]
        public ActionResult GetAuthorizeButtonColumnList(string url)
        {
            Dictionary<string, string> dicButton = new Dictionary<string, string>();
            Dictionary<string, string> dicColumn = new Dictionary<string, string>();

            Model_Mod moduleEntity = ModBll.GetModuleByUrl(url);

            if (moduleEntity != null)
            {
                List<ModuleBtn_Mod> buttonList = ModBll.GetButtonList(moduleEntity.F_ModuleId);
                foreach (var item in buttonList)
                {
                    if (!dicButton.ContainsKey(item.F_EnCode))
                    {
                        dicButton.Add(item.F_EnCode, item.F_FullName);
                    }
                }
                List<ModuleColumn_Mod> columnList = ModBll.GetColumnList(moduleEntity.F_ModuleId);
                foreach (var item in columnList)
                {
                    if (!dicColumn.ContainsKey(item.F_EnCode))
                    {
                        dicColumn.Add(item.F_EnCode.ToLower(), item.F_FullName);
                    }
                }
            }

            var jsonData = new
            {
                module = moduleEntity,
                btns = dicButton,
                cols = dicColumn
            };

            return this.Success(jsonData);
        }
    }
}