using System;
using System.Collections.Generic;

namespace Aymadoka.Static.CollectionExtension
{
    public static partial class CollectionExtensions
    {
        public static void AddRangeIf<T>(this ICollection<T> @this, Func<T, bool> predicate, params T[] values)
        {
            foreach (T value in values)
            {
                if (predicate(value))
                {
                    @this.Add(value);
                }
            }
        }
    }
}
