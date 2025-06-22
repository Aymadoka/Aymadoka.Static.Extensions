namespace Aymadoka.Static.StringExtension
{

    public static partial class StringExtensions
    {
        /// <summary>
        /// 为字符串创建一个新的副本。
        /// </summary>
        /// <param name="str">要复制的字符串，可以为 null。</param>
        /// <returns>字符串的新副本；如果 <paramref name="str"/> 为 null，则返回 null。</returns>
        public static string? Copy(this string? str)
        {
            if (str == null)
            {
                return null;
            }

            return new string(str.ToCharArray());
        }
    }
}
