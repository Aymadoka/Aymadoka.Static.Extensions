using System;
using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.EnumerableExtension
{
    public static partial class EnumerableExtensions
    {
        public static bool ContainsAny<T>(this IEnumerable<T> @this, params T[] values)
        {
            return values.Any(value => @this.Contains(value));
        }
    }
}
