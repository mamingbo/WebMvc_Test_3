﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPlat_Test_3.Mod.LR_OrganizationModule
{
    public class Company_Mod
    {

        /// <summary>
        /// 公司主键
        /// </summary>
        /// <returns></returns>
        [Column("F_COMPANYID")]
        public string F_CompanyId { get; set; }
        /// <summary>
        /// 公司分类
        /// </summary>
        /// <returns></returns>
        [Column("F_CATEGORY")]
        public int? F_Category { get; set; }
        /// <summary>
        /// 父级主键
        /// </summary>
        /// <returns></returns>
        [Column("F_PARENTID")]
        public string F_ParentId { get; set; }
        /// <summary>
        /// 公司代码
        /// </summary>
        /// <returns></returns>
        [Column("F_ENCODE")]
        public string F_EnCode { get; set; }
        /// <summary>
        /// 公司简称
        /// </summary>
        /// <returns></returns>
        [Column("F_SHORTNAME")]
        public string F_ShortName { get; set; }
        /// <summary>
        /// 公司名称
        /// </summary>
        /// <returns></returns>
        [Column("F_FULLNAME")]
        public string F_FullName { get; set; }
        /// <summary>
        /// 公司性质
        /// </summary>
        /// <returns></returns>
        [Column("F_NATURE")]
        public string F_Nature { get; set; }
        /// <summary>
        /// 外线电话
        /// </summary>
        /// <returns></returns>
        [Column("F_OUTERPHONE")]
        public string F_OuterPhone { get; set; }
        /// <summary>
        /// 内线电话
        /// </summary>
        /// <returns></returns>
        [Column("F_INNERPHONE")]
        public string F_InnerPhone { get; set; }
        /// <summary>
        /// 传真
        /// </summary>
        /// <returns></returns>
        [Column("F_FAX")]
        public string F_Fax { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        /// <returns></returns>
        [Column("F_POSTALCODE")]
        public string F_Postalcode { get; set; }
        /// <summary>
        /// 电子邮箱
        /// </summary>
        /// <returns></returns>
        [Column("F_EMAIL")]
        public string F_Email { get; set; }
        /// <summary>
        /// 负责人
        /// </summary>
        /// <returns></returns>
        [Column("F_MANAGER")]
        public string F_Manager { get; set; }
        /// <summary>
        /// 省主键
        /// </summary>
        /// <returns></returns>
        [Column("F_PROVINCEID")]
        public string F_ProvinceId { get; set; }
        /// <summary>
        /// 市主键
        /// </summary>
        /// <returns></returns>
        [Column("F_CITYID")]
        public string F_CityId { get; set; }
        /// <summary>
        /// 县/区主键
        /// </summary>
        /// <returns></returns>
        [Column("F_COUNTYID")]
        public string F_CountyId { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        /// <returns></returns>
        [Column("F_ADDRESS")]
        public string F_Address { get; set; }
        /// <summary>
        /// 公司主页
        /// </summary>
        /// <returns></returns>
        [Column("F_WEBADDRESS")]
        public string F_WebAddress { get; set; }
        /// <summary>
        /// 成立时间
        /// </summary>
        /// <returns></returns>
        [Column("F_FOUNDEDTIME")]
        public DateTime? F_FoundedTime { get; set; }
        /// <summary>
        /// 经营范围
        /// </summary>
        /// <returns></returns>
        [Column("F_BUSINESSSCOPE")]
        public string F_BusinessScope { get; set; }
        /// <summary>
        /// 排序码
        /// </summary>
        /// <returns></returns>
        [Column("F_SORTCODE")]
        public int? F_SortCode { get; set; }
        /// <summary>
        /// 删除标记
        /// </summary>
        /// <returns></returns>
        [Column("F_DELETEMARK")]
        public int? F_DeleteMark { get; set; }
        /// <summary>
        /// 有效标志
        /// </summary>
        /// <returns></returns>
        [Column("F_ENABLEDMARK")]
        public int? F_EnabledMark { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        /// <returns></returns>
        [Column("F_DESCRIPTION")]
        public string F_Description { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        /// <returns></returns>
        [Column("F_CREATEDATE")]
        public DateTime? F_CreateDate { get; set; }
        /// <summary>
        /// 创建用户主键
        /// </summary>
        /// <returns></returns>
        [Column("F_CREATEUSERID")]
        public string F_CreateUserId { get; set; }
        /// <summary>
        /// 创建用户
        /// </summary>
        /// <returns></returns>
        [Column("F_CREATEUSERNAME")]
        public string F_CreateUserName { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>
        /// <returns></returns>
        [Column("F_MODIFYDATE")]
        public DateTime? F_ModifyDate { get; set; }
        /// <summary>
        /// 修改用户主键
        /// </summary>
        /// <returns></returns>
        [Column("F_MODIFYUSERID")]
        public string F_ModifyUserId { get; set; }
        /// <summary>
        /// 修改用户
        /// </summary>
        /// <returns></returns>
        [Column("F_MODIFYUSERNAME")]
        public string F_ModifyUserName { get; set; }
    }
}