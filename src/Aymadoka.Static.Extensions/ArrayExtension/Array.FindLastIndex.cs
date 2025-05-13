using System;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 查找数组中最后一个匹配指定条件的元素的索引。
        /// </summary>
        /// <typeparam name="T">数组元素的类型。</typeparam>
        /// <param name="array">要搜索的数组。</param>
        /// <param name="match">用于定义要查找元素的条件的谓词。</param>
        /// <returns>返回最后一个匹配元素的索引；如果未找到，则返回 -1。</returns>
        /// <exception cref="ArgumentNullException">如果 <paramref name="array"/> 或 <paramref name="match"/> 为 null，则抛出此异常。</exception>
        public static int FindLastIndex<T>(this T[] array, Predicate<T> match)
        {
            var result = Array.FindLastIndex(array, match);
            return result;
        }

        /// <summary>
        /// 从指定的起始索引开始，向前查找数组中最后一个匹配指定条件的元素的索引。
        /// </summary>
        /// <typeparam name="T">数组元素的类型。</typeparam>
        /// <param name="array">要搜索的数组。</param>
        /// <param name="startIndex">搜索的起始索引（从该索引向前搜索）。</param>
        /// <param name="match">用于定义要查找元素的条件的谓词。</param>
        /// <returns>返回最后一个匹配元素的索引；如果未找到，则返回 -1。</returns>
        /// <exception cref="ArgumentNullException">如果 <paramref name="array"/> 或 <paramref name="match"/> 为 null，则抛出此异常。</exception>
        /// <exception cref="ArgumentOutOfRangeException">如果 <paramref name="startIndex"/> 超出范围，则抛出此异常。</exception>
        public static int FindLastIndex<T>(this T[] array, int startIndex, Predicate<T> match)
        {
            var result = Array.FindLastIndex(array, startIndex, match);
            return result;
        }

        /// <summary>
        /// 从指定的起始索引开始，在指定范围内向前查找数组中最后一个匹配指定条件的元素的索引。
        /// </summary>
        /// <typeparam name="T">数组元素的类型。</typeparam>
        /// <param name="array">要搜索的数组。</param>
        /// <param name="startIndex">搜索的起始索引（从该索引向前搜索）。</param>
        /// <param name="count">要搜索的元素数量。</param>
        /// <param name="match">用于定义要查找元素的条件的谓词。</param>
        /// <returns>返回最后一个匹配元素的索引；如果未找到，则返回 -1。</returns>
        /// <exception cref="ArgumentNullException">如果 <paramref name="array"/> 或 <paramref name="match"/> 为 null，则抛出此异常。</exception>
        /// <exception cref="ArgumentOutOfRangeException">如果 <paramref name="startIndex"/> 或 <paramref name="count"/> 超出范围，则抛出此异常。</exception>
        public static int FindLastIndex<T>(this T[] array, int startIndex, int count, Predicate<T> match)
        {
            var result = Array.FindLastIndex(array, startIndex, count, match);
            return result;
        }
    }
}
