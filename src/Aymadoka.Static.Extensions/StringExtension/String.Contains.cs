using System;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        public static bool Contains(this string @this, string value)
        {
            return @this.IndexOf(value) != -1;
        }

        public static bool Contains(this string @this, string value, StringComparison comparisonType)
        {
            return @this.IndexOf(value, comparisonType) != -1;
        }
    }
}
