namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 拼接两个字符串。
        /// </summary>
        /// <param name="str0">第一个字符串。</param>
        /// <param name="str1">第二个字符串。</param>
        /// <returns>拼接后的字符串。</returns>
        public static string Concat(this string str0, string str1)
        {
            return string.Concat(str0, str1);
        }

        /// <summary>
        /// 拼接三个字符串。
        /// </summary>
        /// <param name="str0">第一个字符串。</param>
        /// <param name="str1">第二个字符串。</param>
        /// <param name="str2">第三个字符串。</param>
        /// <returns>拼接后的字符串。</returns>
        public static string Concat(this string str0, string str1, string str2)
        {
            return string.Concat(str0, str1, str2);
        }

        /// <summary>
        /// 拼接四个字符串。
        /// </summary>
        /// <param name="str0">第一个字符串。</param>
        /// <param name="str1">第二个字符串。</param>
        /// <param name="str2">第三个字符串。</param>
        /// <param name="str3">第四个字符串。</param>
        /// <returns>拼接后的字符串。</returns>
        public static string Concat(this string str0, string str1, string str2, string str3)
        {
            return string.Concat(str0, str1, str2, str3);
        }
    }
}
