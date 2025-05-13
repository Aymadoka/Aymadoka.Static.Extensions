using System;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 从源数组复制指定数量的元素到目标数组。
        /// </summary>
        /// <typeparam name="T">数组中元素的类型。</typeparam>
        /// <param name="this">源数组，从中复制数据。</param>
        /// <param name="destinationArray">目标数组，数据将被复制到此数组。</param>
        /// <param name="length">要复制的元素数量。</param>
        /// <exception cref="ArgumentNullException">当 <paramref name="this"/> 或 <paramref name="destinationArray"/> 为 null 时抛出。</exception>
        /// <exception cref="ArgumentOutOfRangeException">当 <paramref name="length"/> 为负数时抛出。</exception>
        /// <exception cref="ArgumentException">当源数组或目标数组的范围不足以完成复制时抛出。</exception>
        public static void Copy<T>(this T[] @this, T[] destinationArray, int length)
        {
            Array.Copy(@this, destinationArray, length);
        }

        /// <summary>
        /// 从源数组的指定索引开始，复制指定数量的元素到目标数组的指定索引。
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
        public static void Copy<T>(this T[] @this, int sourceIndex, T[] destinationArray, int destinationIndex, int length)
        {
            Array.Copy(@this, sourceIndex, destinationArray, destinationIndex, length);
        }

        /// <summary>
        /// 从源数组复制指定数量的元素到目标数组（使用长整型长度）。
        /// </summary>
        /// <typeparam name="T">数组中元素的类型。</typeparam>
        /// <param name="this">源数组，从中复制数据。</param>
        /// <param name="destinationArray">目标数组，数据将被复制到此数组。</param>
        /// <param name="length">要复制的元素数量（以长整型表示）。</param>
        /// <exception cref="ArgumentNullException">当 <paramref name="this"/> 或 <paramref name="destinationArray"/> 为 null 时抛出。</exception>
        /// <exception cref="ArgumentOutOfRangeException">当 <paramref name="length"/> 为负数时抛出。</exception>
        /// <exception cref="ArgumentException">当源数组或目标数组的范围不足以完成复制时抛出。</exception>
        public static void Copy<T>(this T[] @this, T[] destinationArray, long length)
        {
            Array.Copy(@this, destinationArray, length);
        }

        /// <summary>
        /// 从源数组的指定索引开始，复制指定数量的元素到目标数组的指定索引（使用长整型索引和长度）。
        /// </summary>
        /// <typeparam name="T">数组中元素的类型。</typeparam>
        /// <param name="this">源数组，从中复制数据。</param>
        /// <param name="sourceIndex">源数组中开始复制的索引（从零开始，以长整型表示）。</param>
        /// <param name="destinationArray">目标数组，数据将被复制到此数组。</param>
        /// <param name="destinationIndex">目标数组中开始存储数据的索引（从零开始，以长整型表示）。</param>
        /// <param name="length">要复制的元素数量（以长整型表示）。</param>
        /// <exception cref="ArgumentNullException">当 <paramref name="this"/> 或 <paramref name="destinationArray"/> 为 null 时抛出。</exception>
        /// <exception cref="ArgumentOutOfRangeException">当 <paramref name="sourceIndex"/>、<paramref name="destinationIndex"/> 或 <paramref name="length"/> 为负数时抛出。</exception>
        /// <exception cref="ArgumentException">当源数组或目标数组的范围不足以完成复制时抛出。</exception>
        public static void Copy<T>(this T[] @this, long sourceIndex, T[] destinationArray, long destinationIndex, long length)
        {
            Array.Copy(@this, sourceIndex, destinationArray, destinationIndex, length);
        }
    }
}
