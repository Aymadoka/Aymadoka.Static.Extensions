namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 从字符串中提取位于指定起始字符串 <paramref name="before"/> 和结束字符串 <paramref name="after"/> 之间的子字符串。
        /// 如果未找到起始或结束字符串，则返回空字符串。
        /// </summary>
        /// <param name="this">要操作的原始字符串。</param>
        /// <param name="before">起始字符串。</param>
        /// <param name="after">结束字符串。</param>
        /// <returns>位于 <paramref name="before"/> 和 <paramref name="after"/> 之间的子字符串；如果未找到则返回空字符串。</returns>
        public static string GetBetween(this string @this, string before, string after)
        {
            int beforeStartIndex = @this.IndexOf(before);
            int startIndex = beforeStartIndex + before.Length;
            int afterStartIndex = @this.IndexOf(after, startIndex);

            if (beforeStartIndex == -1 || afterStartIndex == -1)
            {
                return string.Empty;
            }

            return @this.Substring(startIndex, afterStartIndex - startIndex);
        }
    }
}
