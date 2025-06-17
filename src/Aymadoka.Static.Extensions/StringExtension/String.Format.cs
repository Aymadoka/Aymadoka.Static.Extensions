namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 使用一个参数格式化字符串。
        /// </summary>
        /// <param name="format">格式字符串。</param>
        /// <param name="arg0">要格式化的第一个参数。</param>
        /// <returns>格式化后的字符串。</returns>
        public static string Format(this string format, object arg0)
        {
            return string.Format(format, arg0);
        }

        /// <summary>
        /// 使用两个参数格式化字符串。
        /// </summary>
        /// <param name="format">格式字符串。</param>
        /// <param name="arg0">要格式化的第一个参数。</param>
        /// <param name="arg1">要格式化的第二个参数。</param>
        /// <returns>格式化后的字符串。</returns>
        public static string Format(this string format, object arg0, object arg1)
        {
            return string.Format(format, arg0, arg1);
        }

        /// <summary>
        /// 使用三个参数格式化字符串。
        /// </summary>
        /// <param name="format">格式字符串。</param>
        /// <param name="arg0">要格式化的第一个参数。</param>
        /// <param name="arg1">要格式化的第二个参数。</param>
        /// <param name="arg2">要格式化的第三个参数。</param>
        /// <returns>格式化后的字符串。</returns>
        public static string Format(this string format, object arg0, object arg1, object arg2)
        {
            return string.Format(format, arg0, arg1, arg2);
        }

        /// <summary>
        /// 使用参数数组格式化字符串。
        /// </summary>
        /// <param name="format">格式字符串。</param>
        /// <param name="args">要格式化的参数数组。</param>
        /// <returns>格式化后的字符串。</returns>
        public static string Format(this string format, object[] args)
        {
            return string.Format(format, args);
        }
    }
}
