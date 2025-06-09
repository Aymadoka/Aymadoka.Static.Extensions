using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.EnumerableExtension
{
    public static partial class EnumerableExtensions
    {
        /// <summary>
        /// 合并嵌套的 <see cref="IEnumerable{T}"/>，将多个内部集合展平成一个集合。
        /// </summary>
        /// <typeparam name="T">集合元素的类型。</typeparam>
        /// <param name="this">包含多个 <see cref="IEnumerable{T}"/> 的外部集合。</param>
        /// <returns>合并后的单一 <see cref="IEnumerable{T}"/> 集合。</returns>
        public static IEnumerable<T> MergeInnerEnumerable<T>(this IEnumerable<IEnumerable<T>> @this)
        {
            return @this.SelectMany(inner => inner);
        }
    }
}
