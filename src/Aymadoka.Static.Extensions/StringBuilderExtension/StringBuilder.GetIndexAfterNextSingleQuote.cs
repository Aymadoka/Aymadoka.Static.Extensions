using System.Text;

namespace Aymadoka.Static.StringBuilderExtension;

public static partial class StringBuilderExtensions
{
    public static int GetIndexAfterNextSingleQuote(this StringBuilder @this)
    {
        return @this.GetIndexAfterNextSingleQuote(0, false);
    }

    public static int GetIndexAfterNextSingleQuote(this StringBuilder @this, bool allowEscape)
    {
        return @this.GetIndexAfterNextSingleQuote(0, allowEscape);
    }

    public static int GetIndexAfterNextSingleQuote(this StringBuilder @this, int startIndex)
    {
        return @this.GetIndexAfterNextSingleQuote(startIndex, false);
    }

    public static int GetIndexAfterNextSingleQuote(this StringBuilder @this, int startIndex, bool allowEscape)
    {
        while (startIndex < @this.Length)
        {
            char ch = @this[startIndex];
            startIndex++;

            char nextChar;
            if (allowEscape && ch == '\\' && startIndex < @this.Length && ((nextChar = @this[startIndex]) == '\\' || nextChar == '\''))
            {
                startIndex++; // Treat as escape character for \\ or \'
            }
            else if (ch == '\'')
            {
                return startIndex;
            }
        }

        return startIndex;
    }
}
