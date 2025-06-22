using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 将指定的字符串集合作为新行追加到文件末尾，使用默认编码。
        /// </summary>
        /// <param name="this">要追加内容的 <see cref="FileInfo"/> 实例。</param>
        /// <param name="contents">要追加的字符串集合，每个字符串作为一行。</param>
        public static void AppendAllLines(this FileInfo @this, IEnumerable<string> contents)
        {
            File.AppendAllLines(@this.FullName, contents);
        }

        /// <summary>
        /// 将指定的字符串集合作为新行追加到文件末尾，使用指定的编码。
        /// </summary>
        /// <param name="this">要追加内容的 <see cref="FileInfo"/> 实例。</param>
        /// <param name="contents">要追加的字符串集合，每个字符串作为一行。</param>
        /// <param name="encoding">用于写入文件的字符编码。</param>
        public static void AppendAllLines(this FileInfo @this, IEnumerable<string> contents, Encoding encoding)
        {
            File.AppendAllLines(@this.FullName, contents, encoding);
        }
    }
}
