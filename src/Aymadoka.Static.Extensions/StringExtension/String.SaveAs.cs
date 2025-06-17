using System.IO;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 将当前字符串内容保存到指定文件路径。
        /// </summary>
        /// <param name="this">要保存的字符串内容。</param>
        /// <param name="fileName">目标文件路径。</param>
        /// <param name="append">是否追加到文件末尾，默认为 false（覆盖）。</param>
        public static void SaveAs(this string @this, string fileName, bool append = false)
        {
            using (TextWriter tw = new StreamWriter(fileName, append))
            {
                tw.Write(@this);
            }
        }

        /// <summary>
        /// 将当前字符串内容保存到指定 <see cref="FileInfo"/> 文件。
        /// </summary>
        /// <param name="this">要保存的字符串内容。</param>
        /// <param name="file">目标 <see cref="FileInfo"/> 文件。</param>
        /// <param name="append">是否追加到文件末尾，默认为 false（覆盖）。</param>
        public static void SaveAs(this string @this, FileInfo file, bool append = false)
        {
            using (TextWriter tw = new StreamWriter(file.FullName, append))
            {
                tw.Write(@this);
            }
        }
    }
}
