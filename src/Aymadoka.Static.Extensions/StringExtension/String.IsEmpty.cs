namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static bool IsEmpty(this string? @this)
    {
        return string.Empty == @this;
    }
}
