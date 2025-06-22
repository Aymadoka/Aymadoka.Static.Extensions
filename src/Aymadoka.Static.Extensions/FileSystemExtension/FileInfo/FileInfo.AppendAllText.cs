using System;
using System.IO;
using System.Text;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 将指定的字符串内容追加到文件末尾（使用默认编码）。
        /// </summary>
        /// <param name="this">目标 <see cref="FileInfo"/> 实例。</param>
        /// <param name="contents">要追加的文本内容。</param>
        public static void AppendAllText(this FileInfo @this, string contents)
        {
            File.AppendAllText(@this.FullName, contents);
        }

        /// <summary>
        /// 将指定的字符串内容以指定编码追加到文件末尾。
        /// </summary>
        /// <param name="this">目标 <see cref="FileInfo"/> 实例。</param>
        /// <param name="contents">要追加的文本内容。</param>
        /// <param name="encoding">用于写入文本的编码。</param>
        public static void AppendAllText(this FileInfo @this, string contents, Encoding encoding)
        {
            File.AppendAllText(@this.FullName, contents, encoding);
        }
    }
}
