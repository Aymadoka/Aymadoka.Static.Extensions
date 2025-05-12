using System;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 从源数组的指定偏移量开始，复制指定数量的字节到目标数组的指定偏移量。
        /// </summary>
        /// <typeparam name="T">数组中元素的类型。</typeparam>
        /// <param name="this">源数组，从中复制数据。</param>
        /// <param name="srcOffset">源数组中开始复制的字节偏移量（以字节为单位）。</param>
        /// <param name="dst">目标数组，数据将被复制到此数组。</param>
        /// <param name="dstOffset">目标数组中开始存储数据的字节偏移量（以字节为单位）。</param>
        /// <param name="count">要复制的字节数。</param>
        /// <exception cref="ArgumentNullException">当源数组（<paramref name="this"/>）或目标数组（<paramref name="dst"/>）为 null 时抛出。</exception>
        /// <exception cref="ArgumentException">当源或目标偏移量和字节数超出数组边界时抛出。</exception>
        public static void BlockCopy<T>(this T[] @this, int srcOffset, T[] dst, int dstOffset, int count)
        {
            Buffer.BlockCopy(@this, srcOffset, dst, dstOffset, count);
        }
    }
}
