using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.EnumerableExtension
{
    public static partial class EnumerableExtensions
    {
        /// <summary>
        /// 判断指定的 <see cref="IEnumerable{T}"/> 是否为空。
        /// </summary>
        /// <typeparam name="T">集合元素的类型。</typeparam>
        /// <param name="this">要检查的集合。</param>
        /// <returns>如果集合为空，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsEmpty<T>(this IEnumerable<T> @this)
        {
            if (@this is ICollection<T> collection)
            {
                return collection.Count == 0;
            }

            return !@this.Any();
        }
    }
}
