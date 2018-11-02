using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPlat_Test_3.Mod
{
    public class RevertPar_Mod
    {
        /// <summary>
        /// 接口响应码
        /// </summary>
        public ERevertCode code { get; set; }
        /// <summary>
        /// 接口响应消息
        /// </summary>
        public string info { get; set; }
        /// <summary>
        /// 接口响应数据
        /// </summary>
        public object data { get; set; }
    }
}