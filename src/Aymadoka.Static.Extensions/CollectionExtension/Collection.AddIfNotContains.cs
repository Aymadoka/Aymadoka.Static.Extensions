using System.Collections.Generic;

namespace Aymadoka.Static.CollectionExtension
{
    public static partial class CollectionExtensions
    {
        public static bool AddIfNotContains<T>(this ICollection<T> @this, T value)
        {
            if (!@this.Contains(value))
            {
                @this.Add(value);
                return true;
            }

            return false;
        }
    }
}
