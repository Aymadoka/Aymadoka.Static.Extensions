using System;
using System.Collections.Generic;

namespace Aymadoka.Static.DictionaryExtension
{
    public static partial class DictionaryExtensions
    {
        /// <summary>
        /// 向字典中添加指定键和值，如果键已存在则更新其值。
        /// </summary>
        /// <typeparam name="TKey">字典的键类型。</typeparam>
        /// <typeparam name="TValue">字典的值类型。</typeparam>
        /// <param name="this">要操作的字典。</param>
        /// <param name="key">要添加或更新的键。</param>
        /// <param name="value">要设置的值。</param>
        /// <returns>添加或更新后的值。</returns>
        public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue value)
        {
            @this[key] = value;

            return @this[key];
        }

        /// <summary>
        /// 向字典中添加指定键和值，如果键已存在则使用指定的委托更新其值。
        /// </summary>
        /// <typeparam name="TKey">字典的键类型。</typeparam>
        /// <typeparam name="TValue">字典的值类型。</typeparam>
        /// <param name="this">要操作的字典。</param>
        /// <param name="key">要添加或更新的键。</param>
        /// <param name="addValue">当键不存在时要添加的值。</param>
        /// <param name="updateValueFactory">当键已存在时用于生成新值的委托。</param>
        /// <returns>添加或更新后的值。</returns>
        public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue addValue, Func<TKey, TValue, TValue> updateValueFactory)
        {
            if (!@this.ContainsKey(key))
            {
                @this.Add(new KeyValuePair<TKey, TValue>(key, addValue));
            }
            else
            {
                @this[key] = updateValueFactory(key, @this[key]);
            }

            return @this[key];
        }

        /// <summary>
        /// 向字典中添加指定键和值（通过委托生成），如果键已存在则使用指定的委托更新其值。
        /// </summary>
        /// <typeparam name="TKey">字典的键类型。</typeparam>
        /// <typeparam name="TValue">字典的值类型。</typeparam>
        /// <param name="this">要操作的字典。</param>
        /// <param name="key">要添加或更新的键。</param>
        /// <param name="addValueFactory">当键不存在时用于生成值的委托。</param>
        /// <param name="updateValueFactory">当键已存在时用于生成新值的委托。</param>
        /// <returns>添加或更新后的值。</returns>
        public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, Func<TKey, TValue> addValueFactory, Func<TKey, TValue, TValue> updateValueFactory)
        {
            if (!@this.ContainsKey(key))
            {
                @this.Add(new KeyValuePair<TKey, TValue>(key, addValueFactory(key)));
            }
            else
            {
                @this[key] = updateValueFactory(key, @this[key]);
            }

            return @this[key];
        }
    }
}
