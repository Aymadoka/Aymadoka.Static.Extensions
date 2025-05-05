using System;
using System.Collections.Generic;

namespace Aymadoka.Static.DictionaryExtension
{
    public static partial class DictionaryExtensions
    {
        public static TValue? GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue? defaultValue = default) where TValue : class
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            var hasValue = @this.TryGetValue(key, out var value);
            return hasValue ? value : defaultValue;
        }

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
