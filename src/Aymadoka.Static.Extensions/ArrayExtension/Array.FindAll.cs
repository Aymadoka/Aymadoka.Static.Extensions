using System;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 在数组中查找所有匹配指定条件的元素，并以新数组的形式返回。
        /// </summary>
        /// <typeparam name="T">数组元素的类型。</typeparam>
        /// <param name="this">要搜索的数组。</param>
        /// <param name="match">用于定义要查找元素的条件的谓词。</param>
        /// <returns>返回包含所有匹配元素的新数组；如果没有找到匹配项，则返回空数组。</returns>
        /// <exception cref="ArgumentNullException">如果 <paramref name="this"/> 或 <paramref name="match"/> 为 null，则抛出此异常。</exception>
        public static T[] FindAll<T>(this T[] @this, Predicate<T> match)
        {
            var result = Array.FindAll(@this, match);
            return result;
        }
    }
}
