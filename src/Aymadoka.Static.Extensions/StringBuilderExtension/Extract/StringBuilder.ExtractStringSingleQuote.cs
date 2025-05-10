using System;
using System.Text;

namespace Aymadoka.Static.StringBuilderExtension.Extract
{
    public static partial class StringBuilderExtensions
    {
        public static StringBuilder ExtractStringSingleQuote(this StringBuilder @this)
        {
            return @this.ExtractStringSingleQuote(0);
        }

        public static StringBuilder ExtractStringSingleQuote(this StringBuilder @this, out int endIndex)
        {
            return @this.ExtractStringSingleQuote(0, out endIndex);
        }

        public static StringBuilder ExtractStringSingleQuote(this StringBuilder @this, int startIndex)
        {
            int endIndex;
            return @this.ExtractStringSingleQuote(startIndex, out endIndex);
        }

        public static StringBuilder ExtractStringSingleQuote(this StringBuilder @this, int startIndex, out int endIndex)
        {
            var sb = new StringBuilder();

            if (@this.Length > startIndex + 1)
            {
                var ch1 = @this[startIndex];

                if (ch1 == '\'')
                {
                    // WARNING: This is not a valid string, however single quote is often used to make it more readable in text templating
                    // 'my string'

                    var pos = startIndex + 1;

                    while (pos < @this.Length)
                    {
                        var ch = @this[pos];
                        pos++;

                        char nextChar;
                        if (ch == '\\' && pos < @this.Length && ((nextChar = @this[pos]) == '\\' || nextChar == '\''))
                        {
                            sb.Append(nextChar);
                            pos++; // Treat as escape character for \\ or \"
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
