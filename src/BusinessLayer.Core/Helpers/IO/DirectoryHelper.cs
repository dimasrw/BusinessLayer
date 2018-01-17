using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Core.Helpers.IO
{
    public static class DirectoryHelper
    {
        public static bool TryCreateDirectoryIfNotExists(string path)
        {
            bool result = false;
            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                result = true;
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        public static string GetDirectoryFromFilePath(string filePath)
        {
            return Path.GetDirectoryName(filePath);
        }
    }
}
