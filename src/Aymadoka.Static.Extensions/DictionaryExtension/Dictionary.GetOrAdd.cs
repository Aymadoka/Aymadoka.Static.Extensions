using System;
using System.Collections.Generic;

namespace Aymadoka.Static.DictionaryExtension
{
    public static partial class DictionaryExtensions
    {
        /// <summary>
        /// 获取指定键的值，如果不存在则添加指定的值并返回。
        /// </summary>
        /// <typeparam name="TKey">字典的键类型。</typeparam>
        /// <typeparam name="TValue">字典的值类型。</typeparam>
        /// <param name="this">要操作的字典。</param>
        /// <param name="key">要查找的键。</param>
        /// <param name="value">如果键不存在时要添加的值。</param>
        /// <returns>键对应的值。</returns>
        public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue value)
        {
            if (!@this.ContainsKey(key))
            {
                @this.Add(new KeyValuePair<TKey, TValue>(key, value));
            }

            return @this[key];
        }

        /// <summary>
        /// 获取指定键的值，如果不存在则使用指定的工厂方法创建值并添加，然后返回该值。
        /// </summary>
        /// <typeparam name="TKey">字典的键类型。</typeparam>
        /// <typeparam name="TValue">字典的值类型。</typeparam>
        /// <param name="this">要操作的字典。</param>
        /// <param name="key">要查找的键。</param>
        /// <param name="valueFactory">用于生成值的工厂方法。</param>
        /// <returns>键对应的值。</returns>
        public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, Func<TKey, TValue> valueFactory)
        {
            if (!@this.ContainsKey(key))
            {
                @this.Add(new KeyValuePair<TKey, TValue>(key, valueFactory(key)));
            }

            return @this[key];
        }
    }
}
