using System.Collections.Generic;

namespace Aymadoka.Static.DictionaryExtension
{
    public static partial class DictionaryExtensions
    {
        public static void RemoveIfContainsKey<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key)
        {
            if (@this.ContainsKey(key))
            {
                @this.Remove(key);
            }
        }
    }
}
