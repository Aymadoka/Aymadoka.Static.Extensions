using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.EnumerableExtension
{
    public static partial class EnumerableExtensions
    {
        /// <summary>
        /// 判断指定的 <see cref="IEnumerable{T}"/> 是否为 null 或不包含任何元素。
        /// </summary>
        /// <typeparam name="T">集合元素的类型。</typeparam>
        /// <param name="this">要检查的集合。</param>
        /// <returns>如果集合为 null 或为空，则返回 true；否则返回 false。</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> @this)
        {
            if (@this is ICollection<T> collection)
            {
                return @this == null || collection.Count == 0;
            }

            return @this == null || !@this.Any();
        }
    }
}
