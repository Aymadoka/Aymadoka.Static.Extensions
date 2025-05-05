using System;
using System.Collections.Generic;

namespace Aymadoka.Static.EnumerableExtension
{
    public static partial class EnumerableExtensions
    {
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
    }
}
