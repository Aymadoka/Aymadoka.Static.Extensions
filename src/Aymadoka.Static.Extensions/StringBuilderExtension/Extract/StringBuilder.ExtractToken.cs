using System;
using System.Text;

namespace Aymadoka.Static.StringBuilderExtension.Extract
{
    public static partial class StringBuilderExtensions
    {
        public static StringBuilder ExtractToken(this StringBuilder @this)
        {
            return @this.ExtractToken(0);
        }

        public static StringBuilder ExtractToken(this StringBuilder @this, out int endIndex)
        {
            return @this.ExtractToken(0, out endIndex);
        }

        public static StringBuilder ExtractToken(this StringBuilder @this, int startIndex)
        {
            int endIndex;
            return @this.ExtractToken(startIndex, out endIndex);
        }

        public static StringBuilder ExtractToken(this StringBuilder @this, int startIndex, out int endIndex)
        {
            /* A token can be:
             * - Keyword / Literal
             * - Operator
             * - String
             * - Integer
             * - Real
             */

            // CHECK first which type is the token
            var ch1 = @this[startIndex];
            var pos = startIndex + 1;

            switch (ch1)
            {
                case '@':
                    if (pos < @this.Length && @this[pos] == '"')
                    {
                        return @this.ExtractStringArobasDoubleQuote(startIndex, out endIndex);
                    }
                    if (pos < @this.Length && @this[pos] == '\'')
                    {
                        return @this.ExtractStringArobasSingleQuote(startIndex, out endIndex);
                    }

                    break;
                case '"':
                    return @this.ExtractStringDoubleQuote(startIndex, out endIndex);
                case '\'':
                    return @this.ExtractStringSingleQuote(startIndex, out endIndex);
                case '`':
                case '~':
                case '!':
                case '#':
                case '$':
                case '%':
                case '^':
                case '&':
                case '*':
                case '(':
                case ')':
                case '-':
                case '_':
                case '=':
                case '+':
                case '[':
                case ']':
                case '{':
                case '}':
                case '|':
                case ':':
                case ';':
                case ',':
                case '.':
                case '<':
                case '>':
                case '?':
                case '/':
                    return @this.ExtractOperator(startIndex, out endIndex);
                case '0':
                    if (pos < @this.Length && (@this[pos] == 'x' || @this[pos] == 'X'))
                    {
                        return @this.ExtractHexadecimal(startIndex, out endIndex);
                    }

                    return @this.ExtractNumber(startIndex, out endIndex);
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    return @this.ExtractNumber(startIndex, out endIndex);
                default:
                    if ((ch1 >= 'a' && ch1 <= 'z') || (ch1 >= 'A' && ch1 <= 'Z'))
                    {
                        return @this.ExtractKeyword(startIndex, out endIndex);
                    }

                    endIndex = -1;
                    return null;
            }

            throw new Exception("Invalid token");
        }
    }
}
