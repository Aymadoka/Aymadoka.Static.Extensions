using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aymadok.Static.ListExtension
{
    public static class ListExtensions
    {
        public static void ForEach<T>(this IList<T> source, Action<T, int> action)
        {
            for (int i = 0; i < source.Count; i++)
            {
                action(source[i], i);
            }
        }

        public static IEnumerable<IEnumerable<T>> Split<T>(this IList<T> list, int parts)
        {
            int i = 0;
            var splits = from item in list
                         group item by i++ / parts into part
                         select part.AsEnumerable();

            return splits;
        }

        public static bool IsNullOrEmpty<T>(this IList<T> @this)
        {
            return @this == null || @this.Count == 0;
        }

        public static bool IsNotNullOrEmpty<T>(this IList<T> @this)
        {
            return !@this.IsNullOrEmpty();
        }
    }
}
