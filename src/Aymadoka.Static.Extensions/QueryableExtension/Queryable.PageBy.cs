using System;
using System.Linq;

namespace Aymadoka.Static.QueryableExtension
{
    public static partial class QueryableExtensions
    {
        /// <summary>
        /// 对 <see cref="IQueryable{T}"/> 进行分页操作。
        /// </summary>
        /// <typeparam name="T">查询元素的类型。</typeparam>
        /// <param name="query">要分页的查询对象。</param>
        /// <param name="skipCount">要跳过的元素数量。</param>
        /// <param name="maxResultCount">要返回的最大元素数量。</param>
        /// <returns>分页后的 <see cref="IQueryable{T}"/>。</returns>
        /// <exception cref="ArgumentNullException">当 <paramref name="query"/> 为 null 时抛出。</exception>
        public static IQueryable<T> PageBy<T>(this IQueryable<T> query, int skipCount, int maxResultCount)
        {
            if (query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }

            return query.Skip(skipCount).Take(maxResultCount);
        }
    }
}
