using System;
using System.Collections.Generic;

namespace Aymadoka.Static.DictionaryExtension
{
    public static partial class DictionaryExtensions
    {
        /// <summary>
        /// 获取指定键的值，如果不存在则返回默认值（引用类型）。
        /// </summary>
        /// <typeparam name="TKey">键的类型。</typeparam>
        /// <typeparam name="TValue">值的类型（引用类型）。</typeparam>
        /// <param name="this">要查找的字典。</param>
        /// <param name="key">要查找的键。</param>
        /// <param name="defaultValue">未找到时返回的默认值。</param>
        /// <returns>键对应的值，或默认值。</returns>
        public static TValue? GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue? defaultValue = default) where TValue : class
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            var hasValue = @this.TryGetValue(key, out var value);
            return hasValue ? value : defaultValue;
        }

        /// <summary>
        /// 获取指定键的值，如果不存在则返回默认值（值类型）。
        /// </summary>
        /// <typeparam name="TKey">键的类型。</typeparam>
        /// <typeparam name="TValue">值的类型（值类型）。</typeparam>
        /// <param name="this">要查找的字典。</param>
        /// <param name="key">要查找的键。</param>
        /// <param name="defaultValue">未找到时返回的默认值。</param>
        /// <returns>键对应的值，或默认值。</returns>
        public static TValue? GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue? defaultValue) where TValue : struct
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            var hasValue = @this.TryGetValue(key, out var value);
            return hasValue ? value : defaultValue;
        }
    }
}
