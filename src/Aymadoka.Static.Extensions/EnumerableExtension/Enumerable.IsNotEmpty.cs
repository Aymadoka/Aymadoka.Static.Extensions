using System.Collections.Generic;

namespace Aymadoka.Static.EnumerableExtension
{
    public static partial class EnumerableExtensions
    {
        /// <summary>
        /// 判断序列是否不为空。
        /// </summary>
        /// <typeparam name="T">序列元素的类型。</typeparam>
        /// <param name="this">要检查的序列。</param>
        /// <returns>如果序列不为空，则返回 true；否则返回 false。</returns>
        public static bool IsNotEmpty<T>(this IEnumerable<T> @this)
        {
            return !@this.IsEmpty();
        }
    }
}
