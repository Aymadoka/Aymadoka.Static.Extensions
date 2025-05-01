using System;
using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.ArrayExtension
{
    public static class CollectionExtensions
    {
        public static void RemoveWhere<T>(this ICollection<T> @this, Func<T, bool> predicate)
        {
            var list = @this.Where(predicate).ToList();

            foreach (T item in list)
            {
                @this.Remove(item);
            }
        }

        public static void RemoveRange<T>(this ICollection<T> @this, params T[] values)
        {
            foreach (T value in values)
            {
                @this.Remove(value);
            }
        }

        public static void RemoveRangeIf<T>(this ICollection<T> @this, Func<T, bool> predicate, params T[] values)
        {
            foreach (T value in values)
            {
                if (predicate(value))
                {
                    @this.Remove(value);
                }
            }
        }

        public static void RemoveRangeIfContains<T>(this ICollection<T> @this, params T[] values)
        {
            foreach (T value in values)
            {
                if (@this.Contains(value))
                {
                    @this.Remove(value);
                }
            }
        }

        public static void RemoveIfContains<T>(this ICollection<T> @this, T value)
        {
            if (@this.Contains(value))
            {
                @this.Remove(value);
            }
        }

        public static void RemoveIf<T>(this ICollection<T> @this, T value, Func<T, bool> predicate)
        {
            if (predicate(value))
            {
                @this.Remove(value);
            }
        }

        public static void AddRangeIfNotContains<T>(this ICollection<T> @this, params T[] values)
        {
            foreach (T value in values)
            {
                if (!@this.Contains(value))
                {
                    @this.Add(value);
                }
            }
        }

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

        public static void AddRange<T>(this ICollection<T> @this, params T[] values)
        {
            foreach (T value in values)
            {
                @this.Add(value);
            }
        }

        public static bool AddIfNotContains<T>(this ICollection<T> @this, T value)
        {
            if (!@this.Contains(value))
            {
                @this.Add(value);
                return true;
            }

            return false;
        }

        public static bool AddIf<T>(this ICollection<T> @this, Func<T, bool> predicate, T value)
        {
            if (predicate(value))
            {
                @this.Add(value);
                return true;
            }

            return false;
        }

        public static void Swap<T>(this ICollection<T> @this, T oldValue, T newValue)
        {
            if (@this is IList<T> list)
            {
                var oldIndex = list.IndexOf(oldValue);
                while (oldIndex > 0)
                {
                    list.RemoveAt(oldIndex);
                    list.Insert(oldIndex, newValue);
                    oldIndex = list.IndexOf(oldValue);
                }
            }
            else
            {
                var updatedCollection = @this.Select(item => EqualityComparer<T>.Default.Equals(item, oldValue) ? newValue : item).ToList();

                @this.Clear();
                foreach (var item in updatedCollection)
                {
                    @this.Add(item);
                }
            }
        }
    }
}
