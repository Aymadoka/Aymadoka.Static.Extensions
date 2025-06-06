using System;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>将字符串的首字母大写</summary>
        /// <param name="value">要处理的字符串</param>
        /// <returns>首字母大写的字符串；如果输入为 null 或空字符串，则返回原字符串</returns>
        public static DateTime? ToValidDateTimeOrNull(this string @this)
        {
            DateTime date;

            if (DateTime.TryParse(@this, out date))
            {
                return date;
            }

            return null;
        }
    }
}
