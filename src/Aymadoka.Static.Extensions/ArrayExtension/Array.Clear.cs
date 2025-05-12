using System;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 清除数组中从指定索引开始的指定长度的元素，将其设置为默认值。
        /// </summary>
        /// <typeparam name="T">数组中元素的类型。</typeparam>
        /// <param name="this">要清除的数组。</param>
        /// <param name="index">开始清除的起始索引（从零开始）。</param>
        /// <param name="length">要清除的元素数量。</param>
        /// <exception cref="ArgumentNullException">当 <paramref name="this"/> 为 null 时抛出。</exception>
        /// <exception cref="IndexOutOfRangeException">当 <paramref name="index"/> 或 <paramref name="length"/> 超出数组范围时抛出。</exception>
        public static void Clear<T>(this T[] @this, int index, int length)
        {
            Array.Clear(@this, index, length);
        }
    }
}
