using System;

namespace BusinessLayer.Core.Helpers
{
    public class GuidHelper
    {
        public static string CreateGuidString(string format = "N")
        {
            return Guid.NewGuid().ToString(format);
        }
    }
}
