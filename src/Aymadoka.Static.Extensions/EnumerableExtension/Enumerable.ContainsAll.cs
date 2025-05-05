using System;
using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.EnumerableExtension
{
    public static partial class EnumerableExtensions
    {
        public static bool ContainsAll<T>(this IEnumerable<T> @this, params T[] values)
        {
            return values.All(value => @this.Contains(value));
        }
    }
}
