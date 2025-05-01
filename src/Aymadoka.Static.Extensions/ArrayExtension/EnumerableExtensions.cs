using System;
using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.EnumerableExtension
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> @this, Func<T, bool> predicate, bool condition)
        {
            return condition ? @this.Where(predicate) : @this;
        }

        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> @this, Func<T, int, bool> predicate, bool condition)
        {
            return condition ? @this.Where(predicate) : @this;
        }

        public static bool IsEmpty<T>(this IEnumerable<T> @this)
        {
            if (@this is ICollection<T> collection)
            {
                return collection.Count == 0;
            }

            return !@this.Any();
        }

        public static bool IsNotEmpty<T>(this IEnumerable<T> @this)
        {
            return !@this.IsEmpty();
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> @this)
        {
            if (@this is ICollection<T> collection)
            {
                return @this == null || collection.Count == 0;
            }

            return @this == null || @this.Any();
        }

        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> @this)
        {
            return !@this.IsNullOrEmpty();
        }

        public static void ForEach<T>(this IEnumerable<T> @this, Action<T, int> action)
        {
            int index = 0;
            foreach (T item in @this)
            {
                action(item, index);
                index++;
            }
        }

        public static void ForEach<T>(this IEnumerable<T> @this, Action<T> action)
        {
            @this.ForEach((item, _) => action(item));
        }

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

        public static bool ContainsAny<T>(this IEnumerable<T> @this, params T[] values)
        {
            return values.Any(value => @this.Contains(value));
        }

        public static bool ContainsAll<T>(this IEnumerable<T> @this, params T[] values)
        {
            return values.All(value => @this.Contains(value));
        }

        public static IEnumerable<T> MergeDistinctInnerEnumerable<T>(this IEnumerable<IEnumerable<T>> @this)
        {
            return @this.MergeInnerEnumerable().Distinct();
        }

        public static IEnumerable<T> MergeInnerEnumerable<T>(this IEnumerable<IEnumerable<T>> @this)
        {
            return @this.SelectMany(inner => inner);
        }

        public static string StringJoin<T>(this IEnumerable<T> @this, string separator)
        {
            return string.Join(separator, @this);
        }

        public static string StringJoin<T>(this IEnumerable<T> @this, char separator)
        {
            return string.Join(separator, @this);
        }
    }
}
