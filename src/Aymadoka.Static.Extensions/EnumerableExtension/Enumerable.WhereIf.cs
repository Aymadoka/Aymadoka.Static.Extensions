using System;
using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.EnumerableExtension
{
    public static partial class EnumerableExtensions
    {
        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> @this, Func<T, bool> predicate, bool condition)
        {
            return condition ? @this.Where(predicate) : @this;
        }

        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> @this, Func<T, int, bool> predicate, bool condition)
        {
            return condition ? @this.Where(predicate) : @this;
        }
    }
}
