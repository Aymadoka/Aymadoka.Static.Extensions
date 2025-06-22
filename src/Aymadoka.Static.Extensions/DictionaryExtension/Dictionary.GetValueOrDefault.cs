using System.Collections.Generic;

namespace Aymadoka.Static.DictionaryExtension
{
    public static partial class DictionaryExtensions
    {
        /// <summary>
        /// 将当前字典转换为 <see cref="SortedDictionary{TKey, TValue}"/>。
        /// </summary>
        /// <typeparam name="TKey">键的类型。</typeparam>
        /// <typeparam name="TValue">值的类型。</typeparam>
        /// <param name="this">要转换的字典。</param>
        /// <returns>包含相同元素的 <see cref="SortedDictionary{TKey, TValue}"/>。</returns>
        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>(this IDictionary<TKey, TValue> @this)
        {
            return new SortedDictionary<TKey, TValue>(@this);
        }

        /// <summary>
        /// 使用指定的比较器将当前字典转换为 <see cref="SortedDictionary{TKey, TValue}"/>。
        /// </summary>
        /// <typeparam name="TKey">键的类型。</typeparam>
        /// <typeparam name="TValue">值的类型。</typeparam>
        /// <param name="this">要转换的字典。</param>
        /// <param name="comparer">用于比较键的比较器。</param>
        /// <returns>包含相同元素的 <see cref="SortedDictionary{TKey, TValue}"/>。</returns>
        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>(this IDictionary<TKey, TValue> @this, IComparer<TKey> comparer)
        {
            return new SortedDictionary<TKey, TValue>(@this, comparer);
        }
    }
}
