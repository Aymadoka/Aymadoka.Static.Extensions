using System;
using System.Collections.Generic;

namespace Aymadoka.Static.EnumerableExtension
{
    public static partial class EnumerableExtensions
    {
        /// <summary>
        /// 对 <see cref="IEnumerable{T}"/> 的每个元素执行指定操作，并提供元素索引。
        /// </summary>
        /// <typeparam name="T">集合元素的类型。</typeparam>
        /// <param name="this">要遍历的集合。</param>
        /// <param name="action">要对每个元素执行的操作，包含元素和索引。</param>
        public static void ForEach<T>(this IEnumerable<T> @this, Action<T, int> action)
        {
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            int index = 0;
            foreach (T item in @this)
            {
                action(item, index);
                index++;
            }
        }

        /// <summary>
        /// 对 <see cref="IEnumerable{T}"/> 的每个元素执行指定操作。
        /// </summary>
        /// <typeparam name="T">集合元素的类型。</typeparam>
        /// <param name="this">要遍历的集合。</param>
        /// <param name="action">要对每个元素执行的操作。</param>
        public static void ForEach<T>(this IEnumerable<T> @this, Action<T> action)
        {
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            @this.ForEach((item, _) => action(item));
        }
    }
}
