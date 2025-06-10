using System.Collections.Generic;
using System.Collections.Specialized;

namespace Aymadoka.Static.NameValueCollectionExtension
{
    public static partial class NameValueCollectionExtensions
    {
        /// <summary>
        /// 将 <see cref="NameValueCollection"/> 转换为 <see cref="IDictionary{TKey, TValue}"/>。
        /// </summary>
        /// <param name="this">要转换的 <see cref="NameValueCollection"/> 实例。</param>
        /// <returns>包含所有键值对的字典，若集合为 null 则返回空字典。</returns>
        public static IDictionary<string, object> ToDictionary(this NameValueCollection @this)
        {
            var dict = new Dictionary<string, object>();

            if (@this != null)
            {
                foreach (string key in @this.AllKeys)
                {
                    dict.Add(key, @this[key]);
                }
            }

            return dict;
        }
    }
}
