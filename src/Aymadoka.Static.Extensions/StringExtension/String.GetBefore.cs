namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static string GetBefore(this string @this, string value)
    {
        if (@this.IndexOf(value) == -1)
        {
            return "";
        }
        return @this.Substring(0, @this.IndexOf(value));
    }
}
