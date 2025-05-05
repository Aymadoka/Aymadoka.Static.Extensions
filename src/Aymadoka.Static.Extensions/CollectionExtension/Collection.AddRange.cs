using System.Collections.Generic;

namespace Aymadoka.Static.CollectionExtension
{
    public static partial class CollectionExtensions
    {
        public static void AddRange<T>(this ICollection<T> @this, params T[] values)
        {
            foreach (T value in values)
            {
                @this.Add(value);
            }
        }
    }
}
