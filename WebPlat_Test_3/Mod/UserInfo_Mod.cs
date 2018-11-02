using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPlat_Test_3.Mod
{
    public class UserInfo_Mod
    {

        /// <summary>
        /// 用户主键
        /// </summary>		
        public string userId { get; set; }
        /// <summary>
        /// 工号
        /// </summary>	
        public string enCode { get; set; }
        /// <summary>
        /// 账户
        /// </summary>	
        public string account { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>		
        public string password { get; set; }
        /// <summary>
        /// 密码秘钥
        /// </summary>	
        public string secretkey { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string realName { get; set; }
        /// <summary>
        /// 呢称
        /// </summary>	
        public string nickName { get; set; }
        /// <summary>
        /// 头像
        /// </summary>	
        public string headIcon { get; set; }
        /// <summary>
        /// 性别
        /// </summary>	
        public int? gender { get; set; }
        /// <summary>
        /// 手机
        /// </summary>	
        public string mobile { get; set; }
        /// <summary>
        /// 电话
        /// </summary>		
        public string telephone { get; set; }
        /// <summary>
        /// 电子邮件
        /// </summary>	
        public string email { get; set; }
        /// <summary>
        /// QQ号
        /// </summary>		
        public string oICQ { get; set; }
        /// <summary>
        /// 微信号
        /// </summary>	
        public string weChat { get; set; }
        /// <summary>
        /// 公司主键
        /// </summary>		
        public string companyId { get; set; }
        /// <summary>
        /// 部门主键
        /// </summary>		
        public string departmentId { get; set; }
        /// <summary>
        /// 单点登录标识
        /// </summary>		
        public int? openId { get; set; }
        /// <summary>
        /// 角色信息
        /// </summary>
        public string roleIds { get; set; }
        /// <summary>
        /// 岗位信息
        /// </summary>
        public string postIds { get; set; }
        /// <summary>
        /// 是否是超级管理员
        /// </summary>
        public bool isSystem { get; set; }
    }
}