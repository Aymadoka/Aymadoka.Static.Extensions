using System.Collections.Generic;

namespace Aymadoka.Static.CollectionExtension
{
    public static partial class CollectionExtensions
    {
        public static void AddRangeIfNotContains<T>(this ICollection<T> @this, params T[] values)
        {
            foreach (T value in values)
            {
                if (!@this.Contains(value))
                {
                    @this.Add(value);
                }
            }
        }
    }
}
