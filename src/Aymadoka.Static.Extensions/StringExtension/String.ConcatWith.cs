namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static string ConcatWith(this string @this, params string[] values)
    {
        return string.Concat(@this, string.Concat(values));
    }
}
