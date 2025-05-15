using System;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 返回指定值在一维数组中第一次出现的索引，如果未找到则返回 -1。
        /// </summary>
        /// <typeparam name="T">数组元素的类型。</typeparam>
        /// <param name="this">要搜索的一维数组。</param>
        /// <param name="value">要在数组中查找的值。</param>
        /// <returns>如果找到该值，则为其在数组中第一次出现的索引；否则为 -1。</returns>
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="this"/> 为 null 时抛出。
        /// </exception>
        public static int IndexOf<T>(this T[] @this, T value)
        {
            var result = Array.IndexOf(@this, value);
            return result;
        }

        /// <summary>
        /// 返回指定值在一维数组中从指定索引开始第一次出现的索引，如果未找到则返回 -1。
        /// </summary>
        /// <typeparam name="T">数组元素的类型。</typeparam>
        /// <param name="array">要搜索的一维数组。</param>
        /// <param name="value">要在数组中查找的值。</param>
        /// <param name="startIndex">搜索的起始索引。</param>
        /// <returns>如果找到该值，则为其在数组中第一次出现的索引；否则为 -1。</returns>
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="array"/> 为 null 时抛出。
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// 当 <paramref name="startIndex"/> 小于数组的下界或大于数组的上界时抛出。
        /// </exception>
        public static int IndexOf<T>(this T[] array, T value, int startIndex)
        {
            var result = Array.IndexOf(array, value, startIndex);
            return result;
        }

        /// <summary>
        /// 返回指定值在一维数组中从指定索引开始、指定元素数范围内第一次出现的索引，如果未找到则返回 -1。
        /// </summary>
        /// <typeparam name="T">数组元素的类型。</typeparam>
        /// <param name="array">要搜索的一维数组。</param>
        /// <param name="value">要在数组中查找的值。</param>
        /// <param name="startIndex">搜索的起始索引。</param>
        /// <param name="count">要搜索的元素数。</param>
        /// <returns>如果找到该值，则为其在数组中第一次出现的索引；否则为 -1。</returns>
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="array"/> 为 null 时抛出。
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// 当 <paramref name="startIndex"/> 或 <paramref name="count"/> 超出有效范围时抛出。
        /// </exception>
        public static int IndexOf<T>(this T[] array, T value, int startIndex, int count)
        {
            var result = Array.IndexOf(array, value, startIndex, count);
            return result;
        }
    }
}
