using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Reflection;
using System.IO;
using Yahoo.Yui.Compressor;


namespace WebPlat_Test_3.Util
{
    public class CssHelper
    {
        private static CssCompressor cssCompressor = new CssCompressor();

        /// <summary>
        /// 读取css 文件内容并压缩
        /// </summary>
        /// <param name="filePathlist"></param>
        /// <returns></returns>
        public static string ReadCssFile(string[] filePathlist)
        {
            StringBuilder cssStr = new StringBuilder();
            try
            {
                string rootPath = Assembly.GetExecutingAssembly().CodeBase.Replace("/bin/WebPlat_Test_3.DLL", "").Replace("file:///", "");
                foreach (var filePath in filePathlist)
                {
                    string path = rootPath + filePath;
                    if (File.Exists(path))
                    {
                        string content = File.ReadAllText(path, Encoding.UTF8);
                        ////压缩Css文件
                        //content = cssCompressor.Compress(content);
                        cssStr.Append(content);
                    }
                }
                return cssStr.ToString();
            }
            catch (Exception)
            {
                return cssStr.ToString();
            }
        }
    }
}