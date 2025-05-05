using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.EnumerableExtension
{
    public static partial class EnumerableExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> @this)
        {
            if (@this is ICollection<T> collection)
            {
                return @this == null || collection.Count == 0;
            }

            return @this == null || @this.Any();
        }
    }
}
