namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 返回系统公共语言运行时 (CLR) 的内部池中是否有指定的字符串。
        /// </summary>
        /// <param name="str">要查找的字符串。</param>
        /// <returns>
        /// 如果字符串已驻留，则返回对该字符串的引用；否则返回 null。
        /// </returns>
        public static string? IsInterned(this string str)
        {
            return string.IsInterned(str);
        }
    }
}
