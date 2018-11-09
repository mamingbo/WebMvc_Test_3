using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebPlat_Test_3.Mod;

namespace WebPlat_Test_3.Bll.LR_SystemModule
{
    public class Model_Bll
    {



        public List<Model_Mod> GetModuleList()
        {
            List<Model_Mod> list = new List<Model_Mod>();
            Model_Mod info;
            info = new Model_Mod();
            info.F_ModuleId = "1";
            info.F_ParentId = "0";
            info.F_EnCode = "BaseManage";
            info.F_FullName = "单位组织";
            info.F_Icon = "fa fa-coffee";
            info.F_UrlAddress = "";
            info.F_Target = "expand";
            info.F_IsMenu = 1;
            info.F_AllowExpand = 0;
            info.F_IsPublic = 0;
            info.F_SortCode = 1;
            info.F_DeleteMark = 0;
            info.F_EnabledMark = 1;
            info.F_Description = "";
            info.F_ModifyDate = DateTime.Now;
            info.F_ModifyUserId = "System";
            info.F_ModifyUserName = "超级管理员";
            list.Add(info);

            info = new Model_Mod();
            info.F_ModuleId = "1_1";
            info.F_ParentId = "1";
            info.F_EnCode = "CompanyManage";
            info.F_FullName = "公司管理";
            info.F_Icon = "fa fa-sitemap";
            info.F_UrlAddress = "/LR_OrganizationModule/Company/Index";
            info.F_Target = "iframe";
            info.F_IsMenu = 1;
            info.F_AllowExpand = 1;
            info.F_IsPublic = 0;
            info.F_SortCode = 1;
            info.F_DeleteMark = 0;
            info.F_EnabledMark = 1;
            info.F_Description = "";
            info.F_ModifyDate = DateTime.Now;
            info.F_ModifyUserId = "System";
            info.F_ModifyUserName = "超级管理员";
            list.Add(info);



            info = new Model_Mod();
            info.F_ModuleId = "2";
            info.F_ParentId = "0";
            info.F_EnCode = "DevManage";
            info.F_FullName = "设备管理";
            info.F_Icon = "fa fa-coffee";
            info.F_UrlAddress = "";
            info.F_Target = "expand";
            info.F_IsMenu = 1;
            info.F_AllowExpand = 0;
            info.F_IsPublic = 0;
            info.F_SortCode = 2;
            info.F_DeleteMark = 0;
            info.F_EnabledMark = 1;
            info.F_Description = "";
            info.F_ModifyDate = DateTime.Now;
            info.F_ModifyUserId = "System";
            info.F_ModifyUserName = "超级管理员";
            list.Add(info);


            info = new Model_Mod();
            info.F_ModuleId = "2_1";
            info.F_ParentId = "2";
            info.F_EnCode = "DevData";
            info.F_FullName = "设备数据";
            info.F_Icon = "fa fa-sitemap";
            info.F_UrlAddress = "/LR_OrganizationModule/Company/Index";
            info.F_Target = "iframe";
            info.F_IsMenu = 1;
            info.F_AllowExpand = 1;
            info.F_IsPublic = 0;
            info.F_SortCode = 1;
            info.F_DeleteMark = 0;
            info.F_EnabledMark = 1;
            info.F_Description = "";
            info.F_ModifyDate = DateTime.Now;
            info.F_ModifyUserId = "System";
            info.F_ModifyUserName = "超级管理员";
            list.Add(info);

            return list;

        }


        /// <summary>
        /// 功能列表
        /// </summary>
        /// <returns></returns>
        public Model_Mod GetModuleByUrl(string url)
        {
            List<Model_Mod> list = GetModuleList();
            return list.Find(t => t.F_UrlAddress == url);
        }

        /// <summary>
        /// 获取按钮列表数据
        /// </summary>
        /// <param name="moduleId">模块Id</param>
        /// <returns></returns>
        public List<ModuleBtn_Mod> GetButtonList(string moduleId)
        {
            List<ModuleBtn_Mod> list = new List<ModuleBtn_Mod>();

            ModuleBtn_Mod info;


            info = new ModuleBtn_Mod();
            info.F_ModuleButtonId = "95f65bb0-e5c8-4bde-ba6c-09cd3b70a20a";
            info.F_ModuleId = "8";
            info.F_ParentId = "0";
            info.F_EnCode = "lr_add";
            info.F_FullName = "新增";
            info.F_ActionAddress = "/LR_OrganizationModule/Company/Form";
            info.F_SortCode = 1;
            list.Add(info);




            info = new ModuleBtn_Mod();
            info.F_ModuleButtonId = "6843ea2c-ef78-472c-b002-3019af537c07";
            info.F_ModuleId = "8";
            info.F_ParentId = "0";
            info.F_EnCode = "lr_edit";
            info.F_FullName = "编辑";
            info.F_ActionAddress = "/LR_OrganizationModule/Company/Form";
            info.F_SortCode = 2;
            list.Add(info);

            info = new ModuleBtn_Mod();
            info.F_ModuleButtonId = "f0971d26-4a6d-4347-9e38-14782a17c1ce";
            info.F_ModuleId = "8";
            info.F_ParentId = "0";
            info.F_EnCode = "lr_delete";
            info.F_FullName = "删除";
            info.F_ActionAddress = "/LR_OrganizationModule/Company/DeleteForm";
            info.F_SortCode = 3;
            list.Add(info);


            return list;
        }


        /// <summary>
        /// 获取视图列表数据
        /// </summary>
        /// <param name="moduleId">模块Id</param>
        /// <returns></returns>
        public List<ModuleColumn_Mod> GetColumnList(string moduleId)
        {
            List<ModuleColumn_Mod> list = new List<ModuleColumn_Mod>();

            ModuleColumn_Mod info;

  //          [
  //{
  //  "F_ModuleColumnId": "dad68bea-0d10-9e6b-16c7-5783eccdf7aa",
  //  "F_ModuleId": "8",
  //  "F_ParentId": "0",
  //  "F_EnCode": "F_FullName",
  //  "F_FullName": "公司名称",
  //  "F_SortCode": 1,
  //  "F_Description": ""
  //},

        info =new ModuleColumn_Mod();
            info.F_ModuleColumnId = "dad68bea-0d10-9e6b-16c7-5783eccdf7aa";
            info.F_ModuleId = "8";
            info.F_ParentId = "0";
            info.F_EnCode = "F_FullName";
            info.F_FullName = "公司名称";
            info.F_SortCode = 1;
            info.F_Description = "";
            list.Add(info);


            info = new ModuleColumn_Mod();
            info.F_ModuleColumnId = "fd25ed35-e86c-d3a3-5099-a64cdfd9b38a";
            info.F_ModuleId = "8";
            info.F_ParentId = "0";
            info.F_EnCode = "F_EnCode";
            info.F_FullName = "外文名称";
            info.F_SortCode = 2;
            info.F_Description = "";
            list.Add(info);
      

            info = new ModuleColumn_Mod();
            info.F_ModuleColumnId = "4f70dc43-8512-c360-ca80-f00984e6af76";
            info.F_ModuleId = "8";
            info.F_ParentId = "0";
            info.F_EnCode = "F_ShortName";
            info.F_FullName = "中文名称";
            info.F_SortCode = 3;
            info.F_Description = "";
            list.Add(info);
  
            info = new ModuleColumn_Mod();
            info.F_ModuleColumnId = "7aae478e-6a88-4651-7127-fa46e1eb27ea";
            info.F_ModuleId = "8";
            info.F_ParentId = "0";
            info.F_EnCode = "F_Nature";
            info.F_FullName = "公司性质";
            info.F_SortCode = 4;
            info.F_Description = "";
            list.Add(info);
      
            info = new ModuleColumn_Mod();
            info.F_ModuleColumnId = "7231ccf2-11cc-b019-aa48-2bf084a7e851";
            info.F_ModuleId = "8";
            info.F_ParentId = "0";
            info.F_EnCode = "F_FoundedTime";
            info.F_FullName = "成立时间";
            info.F_SortCode = 5;
            info.F_Description = "";
            list.Add(info);
      
            info = new ModuleColumn_Mod();
            info.F_ModuleColumnId = "b62482dd-8fed-f143-8390-41118cc698fe";
            info.F_ModuleId = "8";
            info.F_ParentId = "0";
            info.F_EnCode = "F_Manager";
            info.F_FullName = "负责人";
            info.F_SortCode = 6;
            info.F_Description = "";
            list.Add(info);
      
            info = new ModuleColumn_Mod();
            info.F_ModuleColumnId = "728cf0a2-cefd-94bb-1365-ef8128deed00";
            info.F_ModuleId = "8";
            info.F_ParentId = "0";
            info.F_EnCode = "F_Fax";
            info.F_FullName = "经营范围";
            info.F_SortCode = 7;
            info.F_Description = "";
            list.Add(info);
       
            info = new ModuleColumn_Mod();
            info.F_ModuleColumnId = "ca7896b2-bbbd-39e7-de6e-8cf3cc139a71";
            info.F_ModuleId = "8";
            info.F_ParentId = "0";
            info.F_EnCode = "F_Description";
            info.F_FullName = "备注";
            info.F_SortCode = 8;
            info.F_Description = "";
            list.Add(info);



            return list;
        }


    }
}