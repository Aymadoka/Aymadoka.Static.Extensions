using System;
using System.Text;

namespace Aymadoka.Static.StringBuilderExtension.Extract;

public static partial class StringBuilderExtensions
{
    public static StringBuilder ExtractString(this StringBuilder @this)
    {
        return @this.ExtractString(0);
    }

    public static StringBuilder ExtractString(this StringBuilder @this, out int endIndex)
    {
        return @this.ExtractString(0, out endIndex);
    }

    public static StringBuilder ExtractString(this StringBuilder @this, int startIndex)
    {
        int endIndex;
        return @this.ExtractString(startIndex, out endIndex);
    }

    public static StringBuilder ExtractString(this StringBuilder @this, int startIndex, out int endIndex)
    {
        if (@this.Length > startIndex + 1)
        {
            var ch1 = @this[startIndex];
            var ch2 = @this[startIndex + 1];

            if (ch1 == '@' && ch2 == '"')
            {
                // @"my string"

                return @this.ExtractStringArobasDoubleQuote(startIndex, out endIndex);
            }

            if (ch1 == '@' && ch2 == '\'')
            {
                // WARNING: This is not a valid string, however single quote is often used to make it more readable in text templating
                // @'my string'

                return @this.ExtractStringArobasSingleQuote(startIndex, out endIndex);
            }

            if (ch1 == '"')
            {
                // "my string"

                return @this.ExtractStringDoubleQuote(startIndex, out endIndex);
            }

            if (ch1 == '\'')
            {
                // WARNING: This is not a valid string, however single quote is often used to make it more readable in text templating
                // 'my string'

                return @this.ExtractStringSingleQuote(startIndex, out endIndex);
            }
        }

        endIndex = -1;
        return null;
    }
}
