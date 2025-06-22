using System;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 反转整个一维数组中元素的顺序。
        /// </summary>
        /// <typeparam name="T">数组元素的类型。</typeparam>
        /// <param name="array">要反转的一维数组。</param>
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="array"/> 为 null 时抛出。
        /// </exception>
        public static void Reverse<T>(this T[] array)
        {
            Array.Reverse(array);
        }

        /// <summary>
        /// 反转一维数组中指定范围内元素的顺序。
        /// </summary>
        /// <typeparam name="T">数组元素的类型。</typeparam>
        /// <param name="array">要反转的一维数组。</param>
        /// <param name="index">要反转区间的起始索引。</param>
        /// <param name="length">要反转的元素数。</param>
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="array"/> 为 null 时抛出。
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// 当 <paramref name="index"/> 或 <paramref name="length"/> 小于零时抛出。
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <paramref name="index"/> 和 <paramref name="length"/> 不表示数组中的有效区间时抛出。
        /// </exception>
        public static void Reverse<T>(this T[] array, int index, int length)
        {
            Array.Reverse(array, index, length);
        }
    }
}
