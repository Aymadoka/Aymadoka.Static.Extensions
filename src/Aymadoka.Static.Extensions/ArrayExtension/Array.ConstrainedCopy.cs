using System;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 从源数组中复制指定范围的元素到目标数组的指定位置。
        /// 此方法确保在复制过程中，如果发生错误，目标数组不会被修改。
        /// </summary>
        /// <typeparam name="T">数组中元素的类型。</typeparam>
        /// <param name="this">源数组，从中复制数据。</param>
        /// <param name="sourceIndex">源数组中开始复制的索引（从零开始）。</param>
        /// <param name="destinationArray">目标数组，数据将被复制到此数组。</param>
        /// <param name="destinationIndex">目标数组中开始存储数据的索引（从零开始）。</param>
        /// <param name="length">要复制的元素数量。</param>
        /// <exception cref="ArgumentNullException">当 <paramref name="this"/> 或 <paramref name="destinationArray"/> 为 null 时抛出。</exception>
        /// <exception cref="ArgumentOutOfRangeException">当 <paramref name="sourceIndex"/>、<paramref name="destinationIndex"/> 或 <paramref name="length"/> 为负数时抛出。</exception>
        /// <exception cref="ArgumentException">当源数组或目标数组的范围不足以完成复制时抛出。</exception>
        public static void ConstrainedCopy<T>(this T[] @this, int sourceIndex, T[] destinationArray, int destinationIndex, int length)
        {
            Array.ConstrainedCopy(@this, sourceIndex, destinationArray, destinationIndex, length);
        }
    }
}
