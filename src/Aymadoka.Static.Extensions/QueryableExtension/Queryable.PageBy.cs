using System;
using System.Linq;

namespace Aymadoka.Static.QueryableExtension
{
    public static partial class QueryableExtensions
    {
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
