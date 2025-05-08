using System;
using System.Text;

namespace Aymadoka.Static.StringBuilderExtension.Extract;

public static partial class StringBuilderExtensions
{
    public static StringBuilder ExtractHexadecimal(this StringBuilder @this)
    {
        return @this.ExtractHexadecimal(0);
    }

    public static StringBuilder ExtractHexadecimal(this StringBuilder @this, out int endIndex)
    {
        return @this.ExtractHexadecimal(0, out endIndex);
    }

    public static StringBuilder ExtractHexadecimal(this StringBuilder @this, int startIndex)
    {
        int endIndex;
        return @this.ExtractHexadecimal(startIndex, out endIndex);
    }

    public static StringBuilder ExtractHexadecimal(this StringBuilder @this, int startIndex, out int endIndex)
    {
        // WARNING: This method support all kind of suffix for .NET Runtime Compiler
        // An operator can be any sequence of supported operator character

        if (startIndex + 1 < @this.Length && @this[startIndex] == '0'
            && (@this[startIndex + 1] == 'x' || @this[startIndex + 1] == 'X'))
        {
            var sb = new StringBuilder();

            var hasNumber = false;
            var hasSuffix = false;

            sb.Append(@this[startIndex]);
            sb.Append(@this[startIndex + 1]);

            var pos = startIndex + 2;

            while (pos < @this.Length)
            {
                var ch = @this[pos];
                pos++;

                if (((ch >= '0' && ch <= '9')
                     || (ch >= 'a' && ch <= 'f')
                     || (ch >= 'A' && ch <= 'F'))
                    && !hasSuffix)
                {
                    hasNumber = true;
                    sb.Append(ch);
                }
                else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
                {
                    hasSuffix = true;
                    sb.Append(ch);
                }
                else
                {
                    pos -= 2;
                    break;
                }
            }

            if (hasNumber)
            {
                endIndex = pos;
                return sb;
            }
        }

        endIndex = -1;
        return null;
    }
}
