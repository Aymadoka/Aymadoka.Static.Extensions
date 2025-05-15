using System;
using System.Collections;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 对整个一维泛型数组的元素进行升序排序。
        /// </summary>
        /// <typeparam name="T">数组元素的类型。</typeparam>
        /// <param name="array">要排序的一维数组。</param>
        /// <exception cref="ArgumentNullException">当 <paramref name="array"/> 为 null 时抛出。</exception>
        public static void Sort<T>(this T[] array)
        {
            Array.Sort(array);
        }

        /// <summary>
        /// 对主数组及其对应的从属数组元素进行升序排序。
        /// </summary>
        /// <typeparam name="TKey">主数组元素的类型。</typeparam>
        /// <typeparam name="TValue">从属数组元素的类型。</typeparam>
        /// <param name="array">要排序的主数组。</param>
        /// <param name="items">要根据主数组排序的从属数组。</param>
        /// <exception cref="ArgumentNullException">当 <paramref name="array"/> 或 <paramref name="items"/> 为 null 时抛出。</exception>
        /// <exception cref="ArgumentException">当 <paramref name="array"/> 和 <paramref name="items"/> 的长度不一致时抛出。</exception>
        public static void Sort<TKey, TValue>(this TKey[] array, TValue[] items)
        {
            Array.Sort(array, items);
        }

        /// <summary>
        /// 对一维泛型数组中指定范围的元素进行升序排序。
        /// </summary>
        /// <typeparam name="T">数组元素的类型。</typeparam>
        /// <param name="array">要排序的一维数组。</param>
        /// <param name="index">排序区间的起始索引。</param>
        /// <param name="length">要排序的元素数。</param>
        /// <exception cref="ArgumentNullException">当 <paramref name="array"/> 为 null 时抛出。</exception>
        /// <exception cref="ArgumentOutOfRangeException">当 <paramref name="index"/> 或 <paramref name="length"/> 小于零时抛出。</exception>
        /// <exception cref="ArgumentException">当 <paramref name="index"/> 和 <paramref name="length"/> 不表示数组中的有效区间时抛出。</exception>
        public static void Sort<T>(this T[] array, int index, int length)
        {
            Array.Sort(array, index, length);
        }

        /// <summary>
        /// 对主数组及其对应的从属数组在指定范围内的元素进行升序排序。
        /// </summary>
        /// <typeparam name="TKey">主数组元素的类型。</typeparam>
        /// <typeparam name="TValue">从属数组元素的类型。</typeparam>
        /// <param name="array">要排序的主数组。</param>
        /// <param name="items">要根据主数组排序的从属数组。</param>
        /// <param name="index">排序区间的起始索引。</param>
        /// <param name="length">要排序的元素数。</param>
        /// <exception cref="ArgumentNullException">当 <paramref name="array"/> 或 <paramref name="items"/> 为 null 时抛出。</exception>
        /// <exception cref="ArgumentOutOfRangeException">当 <paramref name="index"/> 或 <paramref name="length"/> 小于零时抛出。</exception>
        /// <exception cref="ArgumentException">当 <paramref name="index"/> 和 <paramref name="length"/> 不表示数组中的有效区间，或 <paramref name="array"/> 和 <paramref name="items"/> 的长度不一致时抛出。</exception>
        public static void Sort<TKey, TValue>(this TKey[] array, TValue[] items, int index, int length)
        {
            Array.Sort(array, items, index, length);
        }

        /// <summary>
        /// 使用指定的比较器对整个一维泛型数组的元素进行排序。
        /// </summary>
        /// <typeparam name="T">数组元素的类型。</typeparam>
        /// <param name="array">要排序的一维数组。</param>
        /// <param name="comparer">用于比较元素的 <see cref="IComparer"/> 实现。</param>
        /// <exception cref="ArgumentNullException">当 <paramref name="array"/> 为 null 时抛出。</exception>
        public static void Sort<T>(this T[] array, IComparer comparer)
        {
            Array.Sort(array, comparer);
        }

        /// <summary>
        /// 使用指定的比较器对主数组及其对应的从属数组元素进行排序。
        /// </summary>
        /// <param name="keys">要排序的主数组。</param>
        /// <param name="items">要根据主数组排序的从属数组。</param>
        /// <param name="comparer">用于比较元素的 <see cref="IComparer"/> 实现。</param>
        /// <exception cref="ArgumentNullException">当 <paramref name="keys"/> 或 <paramref name="items"/> 为 null 时抛出。</exception>
        /// <exception cref="ArgumentException">当 <paramref name="keys"/> 和 <paramref name="items"/> 的长度不一致时抛出。</exception>
        public static void Sort(this Array keys, Array items, IComparer comparer)
        {
            Array.Sort(keys, items, comparer);
        }

        /// <summary>
        /// 使用指定的比较器对一维泛型数组中指定范围的元素进行排序。
        /// </summary>
        /// <typeparam name="T">数组元素的类型。</typeparam>
        /// <param name="array">要排序的一维数组。</param>
        /// <param name="index">排序区间的起始索引。</param>
        /// <param name="length">要排序的元素数。</param>
        /// <param name="comparer">用于比较元素的 <see cref="IComparer"/> 实现。</param>
        /// <exception cref="ArgumentNullException">当 <paramref name="array"/> 为 null 时抛出。</exception>
        /// <exception cref="ArgumentOutOfRangeException">当 <paramref name="index"/> 或 <paramref name="length"/> 小于零时抛出。</exception>
        /// <exception cref="ArgumentException">当 <paramref name="index"/> 和 <paramref name="length"/> 不表示数组中的有效区间时抛出。</exception>
        public static void Sort<T>(this T[] array, int index, int length, IComparer comparer)
        {
            Array.Sort(array, index, length, comparer);
        }

        /// <summary>
        /// 使用指定的比较器对主数组及其对应的从属数组在指定范围内的元素进行排序。
        /// </summary>
        /// <param name="keys">要排序的主数组。</param>
        /// <param name="items">要根据主数组排序的从属数组。</param>
        /// <param name="index">排序区间的起始索引。</param>
        /// <param name="length">要排序的元素数。</param>
        /// <param name="comparer">用于比较元素的 <see cref="IComparer"/> 实现。</param>
        /// <exception cref="ArgumentNullException">当 <paramref name="keys"/> 或 <paramref name="items"/> 为 null 时抛出。</exception>
        /// <exception cref="ArgumentOutOfRangeException">当 <paramref name="index"/> 或 <paramref name="length"/> 小于零时抛出。</exception>
        /// <exception cref="ArgumentException">当 <paramref name="index"/> 和 <paramref name="length"/> 不表示数组中的有效区间，或 <paramref name="keys"/> 和 <paramref name="items"/> 的长度不一致时抛出。</exception>
        public static void Sort(this Array keys, Array items, int index, int length, IComparer comparer)
        {
            Array.Sort(keys, items, index, length, comparer);
        }
    }
}
