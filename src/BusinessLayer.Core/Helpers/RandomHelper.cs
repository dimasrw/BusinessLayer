using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Core.Helpers
{
    public class RandomHelper
    {
        public static T GetRandomItemFromCollection<T>(IList<T> array)
        {
            Random rnd = new Random();
            int r = rnd.Next(array.Count);

            return array[r];
        }
    }
}
