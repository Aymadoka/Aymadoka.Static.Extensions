using Microsoft.Extensions.Caching.Memory;
using System;
using System.Linq.Expressions;

namespace Aymadoka.Static.MemoryCacheExtension
{
    public static class MemoryCacheExtensions 
    {
        public static TValue AddOrGetExisting<TValue>(this IMemoryCache cache, string key, TValue value)
        {
            throw new NotImplementedException();
        }

        public static TValue AddOrGetExisting<TValue>(this IMemoryCache cache, string key, Func<string, TValue> valueFactory)
        {
            throw new NotImplementedException();
        }

        public static TValue AddOrGetExisting<TValue>(this IMemoryCache cache, string key, Func<string, TValue> valueFactory, DateTimeOffset absoluteExpiration, string regionName = null)
        {
            throw new NotImplementedException();
        }

        public static TValue FromCache<T, TValue>(this T @this, IMemoryCache cache, string key, TValue value)
        {
            throw new NotImplementedException();
        }

        public static TValue FromCache<T, TValue>(this T @this, string key, TValue value)
        {
            throw new NotImplementedException();
        }

        public static TValue FromCache<T, TValue>(this T @this, IMemoryCache cache, string key, Expression<Func<T, TValue>> valueFactory)
        {
            throw new NotImplementedException();
        }

        public static TValue FromCache<T, TValue>(this T @this, string key, Expression<Func<T, TValue>> valueFactory)
        {
            throw new NotImplementedException();
        }

        public static TValue FromCache<TKey, TValue>(this TKey @this, Expression<Func<TKey, TValue>> valueFactory)
        {
            throw new NotImplementedException();
        }

        public static TValue FromCache<TKey, TValue>(this TKey @this, IMemoryCache cache, Expression<Func<TKey, TValue>> valueFactory)
        {
            throw new NotImplementedException();
        }
    }
}
