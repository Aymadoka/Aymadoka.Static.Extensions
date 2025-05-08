namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static string GetBetween(this string @this, string before, string after)
    {
        int beforeStartIndex = @this.IndexOf(before);
        int startIndex = beforeStartIndex + before.Length;
        int afterStartIndex = @this.IndexOf(after, startIndex);

        if (beforeStartIndex == -1 || afterStartIndex == -1)
        {
            return string.Empty;
        }

        return @this.Substring(startIndex, afterStartIndex - startIndex);
    }
}
