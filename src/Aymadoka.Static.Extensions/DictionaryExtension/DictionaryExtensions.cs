using System.Collections.Generic;

namespace Aymadoka.Static.DictionaryExtension
{
    public static class DictionaryExtensions
    {
        public static Dictionary<TKey, TValue> TryAdd<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue value)
        {
            if (dict.ContainsKey(key) == false)
            {
                dict.Add(key, value);
            }

            return dict;
        }

        public static Dictionary<TKey, TValue> AddOrReplace<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue value)
        {
            dict[key] = value;

            return dict;
        }



    }
}
