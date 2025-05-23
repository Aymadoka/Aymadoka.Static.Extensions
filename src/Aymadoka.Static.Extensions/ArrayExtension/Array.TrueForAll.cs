using System;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 判断指定数组中的所有元素是否都匹配指定的条件。
        /// </summary>
        /// <typeparam name="T">数组元素的类型。</typeparam>
        /// <param name="array">要检查的数组。</param>
        /// <param name="match">用于定义每个元素是否符合条件的谓词。</param>
        /// <returns>
        /// 如果数组中的每个元素都与指定谓词定义的条件匹配，或者数组为空，则为 <c>true</c>；否则为 <c>false</c>。
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="array"/> 或 <paramref name="match"/> 为 null 时抛出。
        /// </exception>
        public static bool TrueForAll<T>(this T[] array, Predicate<T> match)
        {
            return Array.TrueForAll(array, match);
        }
    }
}
