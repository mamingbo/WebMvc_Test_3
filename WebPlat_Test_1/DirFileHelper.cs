using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace WebPlat_Test_1
{
    public class DirFileHelper
    {
        public static bool IsExistFile(string filePath)
        {
            return File.Exists(filePath);
        }
    }
}