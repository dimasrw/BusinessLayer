using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Core.Extensions.Collections
{
    public static class CollectionExtensions
    {
        public static List<T> ToNonNullList<T>(this IEnumerable<T> collection)
        {
            if (collection != null && collection.Any())
                return collection.ToList();

            return new List<T>();
        }
    }
}
