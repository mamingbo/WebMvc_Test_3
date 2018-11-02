using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebPlat_Test_3.Mod.LR_OrganizationModule;

namespace WebPlat_Test_3.Bll.LR_OrganizationModule
{
    public class Company_Bll
    {

        public List<Company_Mod> GetList()
        {
            List<Company_Mod> list = new List<Company_Mod>();



            Company_Mod info = new Company_Mod();

            info.F_CompanyId = "207fa1a9-160c-4943-a89b-8fa4db0547ce";
            info.F_ParentId = "0";
            info.F_EnCode = "learun.China";
            info.F_ShortName = "力软集团";
            info.F_FullName = "力软信息技术有限公司";
            info.F_Nature = "互联网";
            info.F_Manager = "李阳华";
            info.F_ProvinceId = "310000";
            info.F_CityId = "310100";
            info.F_CountyId = "310112";
            info.F_WebAddress = "http://www.learun.cn/";
            info.F_FoundedTime = DateTime.Now;
            info.F_SortCode = 1;
            info.F_DeleteMark = 0;
            info.F_EnabledMark = 1;
            info.F_ModifyDate =DateTime.Now;
            info.F_ModifyUserId = "System";
            info.F_ModifyUserName = "超级管理员";


            info.F_Description = "你好";

            list.Add(info);

            return list;
        }


    }
}