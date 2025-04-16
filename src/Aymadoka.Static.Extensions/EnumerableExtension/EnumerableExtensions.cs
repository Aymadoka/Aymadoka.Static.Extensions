using System;
using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.EnumerableExtension
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> source, Func<T, bool> predicate, bool condition)
        {
            return condition ? source.Where(predicate) : source;
        }

        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> source, Func<T, int, bool> predicate, bool condition)
        {
            return condition ? source.Where(predicate) : source;
        }

        public static bool IsEmpty<T>(this IEnumerable<T> source)
        {
            return !source.IsNotEmpty();
        }

        public static bool IsNotEmpty<T>(this IEnumerable<T> source)
        {
            return source.Any();
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> items)
        {
            return items == null || !items.Any();
        }

        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> items)
        {
            return !items.IsNullOrEmpty();
        }

        public static void ForEach<T>(this IEnumerable<T> items, Action<T, int> action)
        {
            int index = 0;
            foreach (var item in items)
            {
                action(item, index);
                index++;
            }
        }

        public static void ForEach<T>(this IEnumerable<T> items, Action<T> action)
        {
            items.ForEach((item, _) => action(item));
        }

        public static IEnumerable<IEnumerable<T>> Split<T>(this IEnumerable<T> items, int parts)
        {
            int i = 0;
            var splits = from item in items
                         group item by i++ / parts into part
                         select part.AsEnumerable();

            return splits;
        }







    }
}
