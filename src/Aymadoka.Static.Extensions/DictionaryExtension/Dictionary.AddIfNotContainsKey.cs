using System;
using System.Collections.Generic;

namespace Aymadoka.Static.DictionaryExtension
{
    public static partial class DictionaryExtensions
    {
        /// <summary>
        /// 为 <see cref="IDictionary{TKey, TValue}"/> 添加指定的键和值，如果字典中尚不存在该键。
        /// </summary>
        /// <typeparam name="TKey">字典中键的类型。</typeparam>
        /// <typeparam name="TValue">字典中值的类型。</typeparam>
        /// <param name="this">要操作的字典。</param>
        /// <param name="key">要添加的键。</param>
        /// <param name="value">要添加的值。</param>
        /// <returns>如果添加成功返回 true；如果已存在该键则返回 false。</returns>
        public static bool AddIfNotContainsKey<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue value)
        {
            if (!@this.ContainsKey(key))
            {
                @this.Add(key, value);
                return true;
            }

            return false;
        }

        /// <summary>
        /// 为 <see cref="IDictionary{TKey, TValue}"/> 添加指定的键和值（由工厂方法生成），如果字典中尚不存在该键。
        /// </summary>
        /// <typeparam name="TKey">字典中键的类型。</typeparam>
        /// <typeparam name="TValue">字典中值的类型。</typeparam>
        /// <param name="this">要操作的字典。</param>
        /// <param name="key">要添加的键。</param>
        /// <param name="valueFactory">用于生成值的工厂方法。</param>
        /// <returns>如果添加成功返回 true；如果已存在该键则返回 false。</returns>
        public static bool AddIfNotContainsKey<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, Func<TValue> valueFactory)
        {
            if (!@this.ContainsKey(key))
            {
                @this.Add(key, valueFactory());
                return true;
            }

            return false;
        }

        /// <summary>
        /// 为 <see cref="IDictionary{TKey, TValue}"/> 添加指定的键和值（由工厂方法根据键生成），如果字典中尚不存在该键。
        /// </summary>
        /// <typeparam name="TKey">字典中键的类型。</typeparam>
        /// <typeparam name="TValue">字典中值的类型。</typeparam>
        /// <param name="this">要操作的字典。</param>
        /// <param name="key">要添加的键。</param>
        /// <param name="valueFactory">用于根据键生成值的工厂方法。</param>
        /// <returns>如果添加成功返回 true；如果已存在该键则返回 false。</returns>
        public static bool AddIfNotContainsKey<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, Func<TKey, TValue> valueFactory)
        {
            if (!@this.ContainsKey(key))
            {
                @this.Add(key, valueFactory(key));
                return true;
            }

            return false;
        }
    }
}
