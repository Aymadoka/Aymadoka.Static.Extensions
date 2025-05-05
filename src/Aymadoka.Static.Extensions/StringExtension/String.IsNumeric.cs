using System.Globalization;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>判断字符串是否为数字</summary>
        /// <param name="value">要检查的字符串</param>
        /// <returns>如果字符串是数字，则返回 true；否则返回 false</returns>
        public static bool IsNumeric(this string value)
        {
            if (value.IsNullOrWhiteSpace())
            {
                return false;
            }

            return double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out _);
        }
    }
}
