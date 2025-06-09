using System.Collections.Generic;
using System.Collections.Specialized;

namespace Aymadoka.Static.DictionaryExtension
{
    public static partial class DictionaryExtensions
    {
        /// <summary>
        /// 将 <see cref="IDictionary{TKey, TValue}"/> 转换为 <see cref="NameValueCollection"/>。
        /// </summary>
        /// <param name="this">要转换的字典。</param>
        /// <returns>转换后的 <see cref="NameValueCollection"/>，如果字典为 null 则返回 null。</returns>
        public static NameValueCollection? ToNameValueCollection(this IDictionary<string, string> @this)
        {
            if (@this == null)
            {
                return null;
            }

            var col = new NameValueCollection();
            foreach (var item in @this)
            {
                col.Add(item.Key, item.Value);
            }

            return col;
        }
    }
}
