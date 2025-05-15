using System;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 对数组中的每个元素执行指定的操作，并提供元素索引。
        /// </summary>
        /// <typeparam name="T">数组元素的类型。</typeparam>
        /// <param name="this">要遍历的数组。</param>
        /// <param name="action">要对每个元素及其索引执行的操作。</param>
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="this"/> 或 <paramref name="action"/> 为 null 时抛出。
        /// </exception>
        public static void ForEach<T>(this T[] @this, Action<T, int> action)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            for (int i = 0; i < @this.Length; i++)
            {
                var item = @this[i];
                action(item, i);
            }
        }

        /// <summary>
        /// 对数组中的每个元素执行指定的操作。
        /// </summary>
        /// <typeparam name="T">数组元素的类型。</typeparam>
        /// <param name="this">要遍历的数组。</param>
        /// <param name="action">要对每个元素执行的操作。</param>
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="this"/> 或 <paramref name="action"/> 为 null 时抛出。
        /// </exception>
        public static void ForEach<T>(this T[] @this, Action<T> action)
        {
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            @this.ForEach((item, _) => action(item));
        }
    }
}
