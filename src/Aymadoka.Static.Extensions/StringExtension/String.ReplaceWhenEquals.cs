namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        public static string ReplaceWhenEquals(this string @this, string oldValue, string newValue)
        {
            return @this == oldValue ? newValue : @this;
        }
    }
}
