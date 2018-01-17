using System;
using System.IO;

namespace BusinessLayer.Core.Helpers.IO
{
    public static class FileHelper
    {
        public static bool TryDelete(string filePath)
        {
            try
            {
                File.Delete(filePath);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
