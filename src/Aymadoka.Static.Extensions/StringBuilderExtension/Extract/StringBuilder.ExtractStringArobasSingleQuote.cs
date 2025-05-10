using System;
using System.Text;

namespace Aymadoka.Static.StringBuilderExtension.Extract
{
    public static partial class StringBuilderExtensions
    {
        public static StringBuilder ExtractStringArobasSingleQuote(this StringBuilder @this)
        {
            return @this.ExtractStringArobasSingleQuote(0);
        }

        public static StringBuilder ExtractStringArobasSingleQuote(this StringBuilder @this, out int endIndex)
        {
            return @this.ExtractStringArobasSingleQuote(0, out endIndex);
        }

        public static StringBuilder ExtractStringArobasSingleQuote(this StringBuilder @this, int startIndex)
        {
            int endIndex;
            return @this.ExtractStringArobasSingleQuote(startIndex, out endIndex);
        }

        public static StringBuilder ExtractStringArobasSingleQuote(this StringBuilder @this, int startIndex, out int endIndex)
        {
            var sb = new StringBuilder();

            if (@this.Length > startIndex + 1)
            {
                var ch1 = @this[startIndex];
                var ch2 = @this[startIndex + 1];

                if (ch1 == '@' && ch2 == '\'')
                {
                    // WARNING: This is not a valid string, however single quote is often used to make it more readable in text templating
                    // @'my string'

                    var pos = startIndex + 2;

                    while (pos < @this.Length)
                    {
                        var ch = @this[pos];
                        pos++;

                        if (ch == '\'' && pos < @this.Length && @this[pos] == '\'')
                        {
                            sb.Append(ch);
                            pos++; // Treat as escape character for @'abc''def'
                        }
                        else if (ch == '\'')
                        {
                            endIndex = pos;
                            return sb;
                        }
                        else
                        {
                            sb.Append(ch);
                        }
                    }

                    throw new Exception("Unclosed string starting at position: " + startIndex);
                }
            }

            endIndex = -1;
            return null;
        }
    }
}
