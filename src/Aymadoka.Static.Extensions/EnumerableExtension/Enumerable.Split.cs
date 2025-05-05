using System;
using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.EnumerableExtension
{
    public static partial class EnumerableExtensions
    {
        public static IEnumerable<IEnumerable<T>> Split<T>(this IEnumerable<T> @this, int parts)
        {
            if (parts <= 0)
            {
                throw new ArgumentException("Parts must be greater than 0.", nameof(parts));
            }

            int i = 0;
            var splits = from item in @this
                         group item by i++ / parts into part
                         select part.AsEnumerable();

            return splits;
        }
    }
}
