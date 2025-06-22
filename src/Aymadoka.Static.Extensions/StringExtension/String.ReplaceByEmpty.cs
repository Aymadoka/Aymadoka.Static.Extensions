namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 将字符串中的所有指定子串替换为空字符串。
        /// </summary>
        /// <param name="this">要处理的原始字符串。</param>
        /// <param name="values">需要被替换为空的所有子串。</param>
        /// <returns>替换后的新字符串。</returns>
        public static string ReplaceByEmpty(this string @this, params string[] values)
        {
            foreach (string value in values)
            {
                @this = @this.Replace(value, "");
            }

            return @this;
        }
    }
}
