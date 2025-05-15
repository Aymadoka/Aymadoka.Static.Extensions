using System;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 将指定的字节值设置到数组的指定字节索引位置。
        /// </summary>
        /// <typeparam name="T">数组元素的类型。必须为值类型（struct）。</typeparam>
        /// <param name="array">要设置字节的数组。</param>
        /// <param name="index">要设置的字节的从零开始的索引。</param>
        /// <param name="value">要设置的字节值。</param>
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="array"/> 为 null 时抛出。
        /// </exception>
        /// <exception cref="ArgumentException">
        /// 当 <typeparamref name="T"/> 不是值类型时抛出。
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// 当 <paramref name="index"/> 小于零或大于等于数组的字节长度时抛出。
        /// </exception>
        public static void SetByte<T>(this T[] array, int index, byte value)
        {
            Buffer.SetByte(array, index, value);
        }
    }
}
