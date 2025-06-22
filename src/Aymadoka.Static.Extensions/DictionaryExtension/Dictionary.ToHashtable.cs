using System.Collections;

namespace Aymadoka.Static.DictionaryExtension
{
    public static partial class DictionaryExtensions
    {
        /// <summary>
        /// 将 <see cref="IDictionary"/> 实例转换为 <see cref="Hashtable"/>。
        /// </summary>
        /// <param name="this">要转换的 <see cref="IDictionary"/> 实例。</param>
        /// <returns>包含相同键值对的新 <see cref="Hashtable"/> 实例。</returns>
        public static Hashtable ToHashtable(this IDictionary @this)
        {
            return new Hashtable(@this);
        }
    }
}
