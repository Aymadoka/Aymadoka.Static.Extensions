using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aymadoka.Static.ArrayExtension
{
    public static class NameValueCollectionExtensions
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
