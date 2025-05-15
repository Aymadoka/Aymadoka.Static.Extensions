using System;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 返回指定数组中指定索引处的字节值。
        /// </summary>
        /// <typeparam name="T">数组元素的类型。必须为值类型（struct）。</typeparam>
        /// <param name="array">要获取字节的数组。</param>
        /// <param name="index">要返回的字节的从零开始的索引。</param>
        /// <returns>指定索引处的字节值。</returns>
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="array"/> 为 null 时抛出。
        /// </exception>
        /// <exception cref="ArgumentException">
        /// 当 <typeparamref name="T"/> 不是值类型时抛出。
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// 当 <paramref name="index"/> 小于零或大于等于数组的字节长度时抛出。
        /// </exception>
        public static byte GetByte<T>(this T[] array, int index)
        {
            var result = Buffer.GetByte(array, index);
            return result;
        }
    }
}
