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
            info.F_ModuleId = "2";
            info.F_ParentId = "0";
            info.F_EnCode = "BaseManage";
            info.F_FullName = "单位组织";
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
            info.F_ModuleId = "8";
            info.F_ParentId = "2";
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

            return list;

        }



    }
}