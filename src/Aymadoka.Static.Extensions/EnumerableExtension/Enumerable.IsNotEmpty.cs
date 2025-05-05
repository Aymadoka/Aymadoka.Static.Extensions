using System.Collections.Generic;

namespace Aymadoka.Static.EnumerableExtension
{
    public static partial class EnumerableExtensions
    {
        public static bool IsNotEmpty<T>(this IEnumerable<T> @this)
        {
            return !@this.IsEmpty();
        }
    }
}
