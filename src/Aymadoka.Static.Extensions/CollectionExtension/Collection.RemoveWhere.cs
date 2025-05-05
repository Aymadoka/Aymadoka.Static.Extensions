using System;
using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.CollectionExtension
{
    public static partial class CollectionExtensions
    {
        public static void RemoveWhere<T>(this ICollection<T> @this, Func<T, bool> predicate)
        {
            var list = @this.Where(predicate).ToList();

            foreach (T item in list)
            {
                @this.Remove(item);
            }
        }
    }
}
