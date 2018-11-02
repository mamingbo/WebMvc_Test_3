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
    public class JsHelper
    {

        private static JavaScriptCompressor javaScriptCompressor = new JavaScriptCompressor();

        /// <summary>
        /// 读取js文件内容并压缩
        /// </summary>
        /// <param name="filePathlist"></param>
        /// <returns></returns>
        public static string ReadJSFile(string[] filePathlist)
        {
            StringBuilder jsStr = new StringBuilder();
            try
            {
                string rootPath = Assembly.GetExecutingAssembly().CodeBase.Replace("/bin/WebPlat_Test_3.DLL", "").Replace("file:///", "");
                foreach (var filePath in filePathlist)
                {
                    string path = rootPath + filePath;
                    if (File.Exists(path))
                    {
                        string content = File.ReadAllText(path, Encoding.UTF8);

                        //是否压缩JS文件
                        //content = javaScriptCompressor.Compress(content);
                    
                        jsStr.Append(content);
                    }
                }
                return jsStr.ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}