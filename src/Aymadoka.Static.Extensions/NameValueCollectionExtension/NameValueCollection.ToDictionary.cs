using System.Collections.Generic;
using System.Collections.Specialized;

namespace Aymadoka.Static.NameValueCollectionExtension
{
    public static partial class NameValueCollectionExtensions
    {
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
