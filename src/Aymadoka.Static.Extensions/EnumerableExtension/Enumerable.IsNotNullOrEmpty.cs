using System.Collections.Generic;

namespace Aymadoka.Static.EnumerableExtension
{
    public static partial class EnumerableExtensions
    {
        /// <summary>
        /// 判断集合是否不为 null 且包含至少一个元素。
        /// </summary>
        /// <typeparam name="T">集合元素类型。</typeparam>
        /// <param name="this">要检查的集合。</param>
        /// <returns>如果集合不为 null 且包含元素，则返回 true；否则返回 false。</returns>
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> @this)
        {
            return !@this.IsNullOrEmpty();
        }
    }
}
