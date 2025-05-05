using System.Collections;

namespace Aymadoka.Static.DictionaryExtension
{
    public static partial class DictionaryExtensions
    {
        public static Hashtable ToHashtable(this IDictionary @this)
        {
            return new Hashtable(@this);
        }
    }
}
