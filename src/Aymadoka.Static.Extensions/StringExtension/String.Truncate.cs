namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static string Truncate(this string @this, int maxLength)
    {
        const string suffix = "...";

        if (@this == null || @this.Length <= maxLength)
        {
            return @this;
        }

        int strLength = maxLength - suffix.Length;
        return @this.Substring(0, strLength) + suffix;
    }

    public static string Truncate(this string @this, int maxLength, string suffix)
    {
        if (@this == null || @this.Length <= maxLength)
        {
            return @this;
        }

        int strLength = maxLength - suffix.Length;
        return @this.Substring(0, strLength) + suffix;
    }
}
