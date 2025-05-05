using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.EnumerableExtension
{
    public static partial class EnumerableExtensions
    {
        public static bool IsEmpty<T>(this IEnumerable<T> @this)
        {
            if (@this is ICollection<T> collection)
            {
                return collection.Count == 0;
            }

            return !@this.Any();
        }
    }
}
