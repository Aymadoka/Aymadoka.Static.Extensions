using System;
using System.Text;

namespace Aymadoka.Static.StringBuilderExtension.Extract
{
    public static partial class StringBuilderExtensions
    {
        public static StringBuilder ExtractOperator(this StringBuilder @this)
        {
            return @this.ExtractOperator(0);
        }

        public static StringBuilder ExtractOperator(this StringBuilder @this, out int endIndex)
        {
            return @this.ExtractOperator(0, out endIndex);
        }

        public static StringBuilder ExtractOperator(this StringBuilder @this, int startIndex)
        {
            int endIndex;
            return @this.ExtractOperator(startIndex, out endIndex);
        }

        public static StringBuilder ExtractOperator(this StringBuilder @this, int startIndex, out int endIndex)
        {
            // WARNING: This method support custom operator for .NET Runtime Compiler
            // An operator can be any sequence of supported operator character
            var sb = new StringBuilder();

            var pos = startIndex;

            while (pos < @this.Length)
            {
                var ch = @this[pos];
                pos++;

                switch (ch)
                {
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
                        sb.Append(ch);
                        break;
                    default:
                        if (sb.Length > 0)
                        {
                            endIndex = pos - 2;
                            return sb;
                        }

                        endIndex = -1;
                        return null;
                }
            }

            if (sb.Length > 0)
            {
                endIndex = pos;
                return sb;
            }

            endIndex = -1;
            return null;
        }
    }
}
