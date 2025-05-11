using System;
using System.Collections;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 在整个一维数组中搜索指定的值，并返回其索引。
        /// </summary>
        /// <typeparam name="T">数组中元素的类型。</typeparam>
        /// <param name="this">要搜索的数组。</param>
        /// <param name="value">要搜索的值。</param>
        /// <returns>如果找到，返回值的索引；否则返回一个负数，表示未找到。</returns>
        /// <exception cref="ArgumentNullException">当 <paramref name="this"/> 为 null 时抛出。</exception>
        public static int BinarySearch<T>(this T[] @this, T value)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this), "The input array cannot be empty.");
            }

            var result = Array.BinarySearch(@this, value);
            return result;
        }
        /// <summary>
        /// 在一维数组的指定范围内搜索指定的值，并返回其索引。
        /// </summary>
        /// <typeparam name="T">数组中元素的类型。</typeparam>
        /// <param name="this">要搜索的数组。</param>
        /// <param name="index">搜索范围的起始索引。</param>
        /// <param name="length">搜索范围的长度。</param>
        /// <param name="value">要搜索的值。</param>
        /// <returns>如果找到，返回值的索引；否则返回一个负数，表示未找到。</returns>
        /// <exception cref="ArgumentNullException">当 <paramref name="this"/> 为 null 时抛出。</exception>
        /// <exception cref="ArgumentOutOfRangeException">当 <paramref name="index"/> 或 <paramref name="length"/> 超出范围时抛出。</exception>
        public static int BinarySearch<T>(this T[] @this, int index, int length, T value)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this), "The input array cannot be empty.");
            }

            var result = Array.BinarySearch(@this, index, length, value);
            return result;
        }

        /// <summary>
        /// 在整个一维数组中使用指定的比较器搜索指定的值，并返回其索引。
        /// </summary>
        /// <typeparam name="T">数组中元素的类型。</typeparam>
        /// <param name="this">要搜索的数组。</param>
        /// <param name="value">要搜索的值。</param>
        /// <param name="comparer">用于比较元素的自定义比较器。</param>
        /// <returns>如果找到，返回值的索引；否则返回一个负数，表示未找到。</returns>
        /// <exception cref="ArgumentNullException">当 <paramref name="this"/> 为 null 时抛出。</exception>
        public static int BinarySearch<T>(this T[] @this, T value, IComparer comparer)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this), "The input array cannot be empty.");
            }

            var result = Array.BinarySearch(@this, value, comparer);
            return result;
        }

        /// <summary>
        /// 在一维数组的指定范围内使用指定的比较器搜索指定的值，并返回其索引。
        /// </summary>
        /// <typeparam name="T">数组中元素的类型。</typeparam>
        /// <param name="this">要搜索的数组。</param>
        /// <param name="index">搜索范围的起始索引。</param>
        /// <param name="length">搜索范围的长度。</param>
        /// <param name="value">要搜索的值。</param>
        /// <param name="comparer">用于比较元素的自定义比较器。</param>
        /// <returns>如果找到，返回值的索引；否则返回一个负数，表示未找到。</returns>
        /// <exception cref="ArgumentNullException">当 <paramref name="this"/> 为 null 时抛出。</exception>
        /// <exception cref="ArgumentOutOfRangeException">当 <paramref name="index"/> 或 <paramref name="length"/> 超出范围时抛出。</exception>
        public static int BinarySearch<T>(this T[] @this, int index, int length, T value, IComparer comparer)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this), "The input array cannot be empty.");
            }

            var result = Array.BinarySearch(@this, index, length, value, comparer);
            return result;
        }
    }
}
