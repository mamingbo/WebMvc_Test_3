﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace WebPlat_Test_3.Mod
{
    public class ModuleButton_Mod
    {

        /// <summary>
        /// 按钮主键
        /// </summary>
        /// <returns></returns>
        [Column("F_MODULEBUTTONID")]
        public string F_ModuleButtonId { get; set; }
        /// <summary>
        /// 功能主键
        /// </summary>
        /// <returns></returns>
        [Column("F_MODULEID")]
        public string F_ModuleId { get; set; }
        /// <summary>
        /// 父级主键
        /// </summary>
        /// <returns></returns>
        [Column("F_PARENTID")]
        public string F_ParentId { get; set; }
        /// <summary>
        /// 图标
        /// </summary>
        /// <returns></returns>
        [Column("F_ICON")]
        public string F_Icon { get; set; }
        /// <summary>
        /// 编码
        /// </summary>
        /// <returns></returns>
        [Column("F_ENCODE")]
        public string F_EnCode { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        /// <returns></returns>
        [Column("F_FULLNAME")]
        public string F_FullName { get; set; }
        /// <summary>
        /// Action地址
        /// </summary>
        /// <returns></returns>
        [Column("F_ACTIONADDRESS")]
        public string F_ActionAddress { get; set; }
        /// <summary>
        /// 排序码
        /// </summary>
        /// <returns></returns>
        [Column("F_SORTCODE")]
        public int? F_SortCode { get; set; }
    }
}