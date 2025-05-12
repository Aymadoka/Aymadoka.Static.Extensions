using System;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 清除数组中指定索引处的元素，将其设置为默认值。
        /// </summary>
        /// <typeparam name="T">数组中元素的类型。</typeparam>
        /// <param name="this">要清除的数组。</param>
        /// <param name="at">要清除的元素的索引（从零开始）。</param>
        /// <exception cref="ArgumentNullException">当 <paramref name="this"/> 为 null 时抛出。</exception>
        /// <exception cref="IndexOutOfRangeException">当 <paramref name="at"/> 超出数组范围时抛出。</exception>
        public static void ClearAt<T>(this T[] @this, int at)
        {
            Array.Clear(@this, at, 1);
        }
    }
}
