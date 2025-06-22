using System;
using System.IO;
using System.Text;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 将指定的字符串内容写入到当前 <see cref="FileInfo"/> 表示的文件中（使用默认编码）。
        /// </summary>
        /// <param name="this">目标文件。</param>
        /// <param name="contents">要写入的字符串内容。</param>
        public static void WriteAllText(this FileInfo @this, String contents)
        {
            File.WriteAllText(@this.FullName, contents);
        }

        /// <summary>
        /// 将指定的字符串内容以指定编码写入到当前 <see cref="FileInfo"/> 表示的文件中。
        /// </summary>
        /// <param name="this">目标文件。</param>
        /// <param name="contents">要写入的字符串内容。</param>
        /// <param name="encoding">用于写入内容的编码。</param>
        public static void WriteAllText(this FileInfo @this, String contents, Encoding encoding)
        {
            File.WriteAllText(@this.FullName, contents, encoding);
        }
    }
}
