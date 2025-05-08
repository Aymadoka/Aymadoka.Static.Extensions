namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static string? NullIfEmpty(this string? @this)
    {
        if (@this.IsEmpty())
        {
            return null;
        }

        return @this;
    }
}
