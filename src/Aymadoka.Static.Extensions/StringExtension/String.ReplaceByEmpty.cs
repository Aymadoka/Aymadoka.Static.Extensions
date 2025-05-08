namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static string ReplaceByEmpty(this string @this, params string[] values)
    {
        foreach (string value in values)
        {
            @this = @this.Replace(value, "");
        }

        return @this;
    }
}
