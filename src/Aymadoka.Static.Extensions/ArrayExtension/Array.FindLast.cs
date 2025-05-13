using System;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 查找数组中最后一个匹配指定条件的元素。
        /// </summary>
        /// <typeparam name="T">数组元素的类型。</typeparam>
        /// <param name="this">要搜索的数组。</param>
        /// <param name="match">用于定义要查找元素的条件的谓词。</param>
        /// <returns>返回最后一个匹配元素；如果未找到，则返回类型 <typeparamref name="T"/> 的默认值。</returns>
        /// <exception cref="ArgumentNullException">如果 <paramref name="this"/> 或 <paramref name="match"/> 为 null，则抛出此异常。</exception>
        public static T FindLast<T>(this T[] @this, Predicate<T> match)
        {
            var result = Array.FindLast(@this, match);
            return result;
        }
    }
}
