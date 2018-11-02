using System;
using System.IO;
using System.Reflection;
using System.Text;
using Yahoo.Yui.Compressor;

namespace WebPlat_Test_1
{
    public class JsCssHelper
    {

        private static JavaScriptCompressor javaScriptCompressor = new JavaScriptCompressor();
        private static CssCompressor cssCompressor = new CssCompressor();


        public static string ReadCssFile(string[] filePathlist)
        {
            StringBuilder cssStr = new StringBuilder();
            try
            {
                string rootPath = Assembly.GetExecutingAssembly().CodeBase.Replace("/bin/WebPlat_Test_1.DLL", "").Replace("file:///", "");
                foreach (var filePath in filePathlist)
                {
                    string path = rootPath + filePath;
                    if (DirFileHelper.IsExistFile(path))
                    {
                        string content = File.ReadAllText(path, Encoding.UTF8);
                        content = cssCompressor.Compress(content);
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
                string rootPath = Assembly.GetExecutingAssembly().CodeBase.Replace("/bin/WebPlat_Test_1.DLL", "").Replace("file:///", "");
                foreach (var filePath in filePathlist)
                {
                    string path = rootPath + filePath;
                    if (DirFileHelper.IsExistFile(path))
                    {
                        string content = File.ReadAllText(path, Encoding.UTF8);
                       // content = javaScriptCompressor.Compress(content);
                        jsStr.Append(content);
                    }
                }
                return jsStr.ToString();
            }
            catch (Exception ex)
            {
                String sddd = ex.ToString();
                string ssddd = ex.Message;
                return "";
            }
        }



    }
}