using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.EnumerableExtension
{
    public static partial class EnumerableExtensions
    {
        /// <summary>
        /// 合并多个内部 <see cref="IEnumerable{T}"/>，并返回去重后的元素序列。
        /// </summary>
        /// <typeparam name="T">元素类型。</typeparam>
        /// <param name="this">包含多个 <see cref="IEnumerable{T}"/> 的序列。</param>
        /// <returns>合并并去重后的元素序列。</returns>
        public static IEnumerable<T> MergeDistinctInnerEnumerable<T>(this IEnumerable<IEnumerable<T>> @this)
        {
            return @this.MergeInnerEnumerable().Distinct();
        }
    }
}
