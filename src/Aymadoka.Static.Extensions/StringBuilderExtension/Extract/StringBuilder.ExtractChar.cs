using System;
using System.Text;

namespace Aymadoka.Static.StringBuilderExtension.Extract
{
    public static partial class StringBuilderExtensions
    {
        public static char ExtractChar(this StringBuilder @this)
        {
            return @this.ExtractChar(0);
        }

        public static char ExtractChar(this StringBuilder @this, out int endIndex)
        {
            return @this.ExtractChar(0, out endIndex);
        }

        public static char ExtractChar(this StringBuilder @this, int startIndex)
        {
            int endIndex;
            return @this.ExtractChar(startIndex, out endIndex);
        }

        public static char ExtractChar(this StringBuilder @this, int startIndex, out int endIndex)
        {
            if (@this.Length > startIndex + 1)
            {
                var ch1 = @this[startIndex];
                var ch2 = @this[startIndex + 1];
                var ch3 = @this[startIndex + 2];

                if (ch1 == '\'' && ch3 == '\'')
                {
                    endIndex = startIndex + 2;
                    return ch2;
                }
            }

            throw new Exception("Invalid char at position: " + startIndex);
        }
    }
}
