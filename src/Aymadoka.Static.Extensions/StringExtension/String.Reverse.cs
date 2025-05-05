using System;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>反转字符串</summary>
        /// <param name="value">要反转的字符串</param>
        /// <returns>反转后的字符串；如果输入为 null 或仅包含空白字符，则返回原字符串</returns>
        public static string? Reverse(this string? value)
        {
            if (value.IsNullOrWhiteSpace())
            {
                return value;
            }

            var charArray = value.ToCharArray();
            Array.Reverse(charArray);
            var reversed = new string(charArray);

            return reversed;
        }
    }
}
