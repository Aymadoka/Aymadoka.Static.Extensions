using System.Text;

namespace Aymadoka.Static.StringBuilderExtension.Extract;

public static partial class StringBuilderExtensions
{
    public static StringBuilder ExtractKeyword(this StringBuilder @this)
    {
        return @this.ExtractKeyword(0);
    }

    public static StringBuilder ExtractKeyword(this StringBuilder @this, out int endIndex)
    {
        return @this.ExtractKeyword(0, out endIndex);
    }

    public static StringBuilder ExtractKeyword(this StringBuilder @this, int startIndex)
    {
        int endIndex;
        return @this.ExtractKeyword(startIndex, out endIndex);
    }

    public static StringBuilder ExtractKeyword(this StringBuilder @this, int startIndex, out int endIndex)
    {
        // WARNING: This method support custom operator for .NET Runtime Compiler
        // An operator can be any sequence of supported operator character
        var sb = new StringBuilder();

        var pos = startIndex;
        var hasCharacter = false;

        while (pos < @this.Length)
        {
            var ch = @this[pos];
            pos++;

            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                hasCharacter = true;
                sb.Append(ch);
            }
            else if (ch == '@')
            {
                sb.Append(ch);
            }
            else if (ch >= '0' && ch <= '9' && hasCharacter)
            {
                sb.Append(ch);
            }
            else
            {
                pos -= 2;
                break;
            }
        }

        if (hasCharacter)
        {
            endIndex = pos;
            return sb;
        }

        endIndex = -1;
        return null;
    }
}
