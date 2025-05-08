namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static string Replace(this string @this, int startIndex, int length, string value)
    {
        @this = @this.Remove(startIndex, length).Insert(startIndex, value);

        return @this;
    }
}
