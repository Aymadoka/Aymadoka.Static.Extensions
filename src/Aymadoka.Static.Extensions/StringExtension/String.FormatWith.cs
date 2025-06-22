namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 使用指定的参数格式化字符串。
        /// </summary>
        /// <param name="this">要格式化的字符串。</param>
        /// <param name="arg0">第一个格式化参数。</param>
        /// <returns>格式化后的字符串。</returns>
        public static string FormatWith(this string @this, object arg0)
        {
            return string.Format(@this, arg0);
        }

        /// <summary>
        /// 使用指定的参数格式化字符串。
        /// </summary>
        /// <param name="this">要格式化的字符串。</param>
        /// <param name="arg0">第一个格式化参数。</param>
        /// <param name="arg1">第二个格式化参数。</param>
        /// <returns>格式化后的字符串。</returns>
        public static string FormatWith(this string @this, object arg0, object arg1)
        {
            return string.Format(@this, arg0, arg1);
        }

        /// <summary>
        /// 使用指定的参数格式化字符串。
        /// </summary>
        /// <param name="this">要格式化的字符串。</param>
        /// <param name="arg0">第一个格式化参数。</param>
        /// <param name="arg1">第二个格式化参数。</param>
        /// <param name="arg2">第三个格式化参数。</param>
        /// <returns>格式化后的字符串。</returns>
        public static string FormatWith(this string @this, object arg0, object arg1, object arg2)
        {
            return string.Format(@this, arg0, arg1, arg2);
        }

        /// <summary>
        /// 使用指定的参数数组格式化字符串。
        /// </summary>
        /// <param name="this">要格式化的字符串。</param>
        /// <param name="values">格式化参数数组。</param>
        /// <returns>格式化后的字符串。</returns>
        public static string FormatWith(this string @this, params object[] values)
        {
            return string.Format(@this, values);
        }
    }
}
