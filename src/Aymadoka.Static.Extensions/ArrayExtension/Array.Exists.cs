using System;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 判断数组中是否存在满足指定条件的元素。
        /// </summary>
        /// <typeparam name="T">数组元素的类型。</typeparam>
        /// <param name="this">要搜索的数组。</param>
        /// <param name="match">用于定义要搜索的元素的条件的谓词。</param>
        /// <returns>如果数组中存在至少一个元素满足条件，则返回 true；否则返回 false。</returns>
        /// <exception cref="ArgumentNullException">如果 <paramref name="this"/> 或 <paramref name="match"/> 为 null，则抛出此异常。</exception>
        public static bool Exists<T>(this T[] @this, Predicate<T> match)
        {
            var result = Array.Exists(@this, match);
            return result;
        }
    }
}
