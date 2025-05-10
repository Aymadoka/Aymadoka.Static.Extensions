using System;

namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        public static T? NullIfEqualsAny<T>(this T @this, params T[] values) where T : class
        {
            if (Array.IndexOf(values, @this) != -1)
            {
                return null;
            }

            return @this;
        }
    }
}
