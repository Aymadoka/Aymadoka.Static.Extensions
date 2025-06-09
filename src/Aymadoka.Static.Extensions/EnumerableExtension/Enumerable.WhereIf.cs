using System;
using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.EnumerableExtension
{
    public static partial class EnumerableExtensions
    {
        /// <summary>
        /// 根据指定条件 condition，决定是否对序列应用筛选谓词 predicate。
        /// </summary>
        /// <typeparam name="T">序列元素的类型。</typeparam>
        /// <param name="this">要筛选的序列。</param>
        /// <param name="predicate">用于筛选元素的谓词。</param>
        /// <param name="condition">为 true 时应用筛选，否则返回原序列。</param>
        /// <returns>筛选后的序列或原序列。</returns>
        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> @this, Func<T, bool> predicate, bool condition)
        {
            return condition ? @this.Where(predicate) : @this;
        }

        /// <summary>
        /// 根据指定条件 condition，决定是否对序列应用带索引的筛选谓词 predicate。
        /// </summary>
        /// <typeparam name="T">序列元素的类型。</typeparam>
        /// <param name="this">要筛选的序列。</param>
        /// <param name="predicate">用于筛选元素的带索引谓词。</param>
        /// <param name="condition">为 true 时应用筛选，否则返回原序列。</param>
        /// <returns>筛选后的序列或原序列。</returns>
        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> @this, Func<T, int, bool> predicate, bool condition)
        {
            return condition ? @this.Where(predicate) : @this;
        }
    }
}
