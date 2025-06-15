using System;
using System.Linq;
using System.Linq.Expressions;

namespace Aymadoka.Static.QueryableExtension
{
    public static partial class QueryableExtensions
    {
        /// <summary>
        /// 根据指定条件有选择性地应用 <see cref="Where"/> 过滤。
        /// </summary>
        /// <typeparam name="T">序列中元素的类型。</typeparam>
        /// <param name="source">要筛选的序列。</param>
        /// <param name="predicate">用于测试每个元素是否满足条件的表达式。</param>
        /// <param name="condition">是否应用筛选条件。</param>
        /// <returns>如果 <paramref name="condition"/> 为 true，则返回应用筛选条件后的序列；否则返回原序列。</returns>
        public static IQueryable<T> WhereIf<T>(this IQueryable<T> source, Expression<Func<T, bool>> predicate, bool condition)
        {
            return condition ? source.Where(predicate) : source;
        }

        /// <summary>
        /// 根据指定条件有选择性地应用带索引的 <see cref="Where"/> 过滤。
        /// </summary>
        /// <typeparam name="T">序列中元素的类型。</typeparam>
        /// <param name="source">要筛选的序列。</param>
        /// <param name="predicate">用于测试每个元素及其索引是否满足条件的表达式。</param>
        /// <param name="condition">是否应用筛选条件。</param>
        /// <returns>如果 <paramref name="condition"/> 为 true，则返回应用筛选条件后的序列；否则返回原序列。</returns>
        public static IQueryable<T> WhereIf<T>(this IQueryable<T> source, Expression<Func<T, int, bool>> predicate, bool condition)
        {
            return condition ? source.Where(predicate) : source;
        }
    }
}
