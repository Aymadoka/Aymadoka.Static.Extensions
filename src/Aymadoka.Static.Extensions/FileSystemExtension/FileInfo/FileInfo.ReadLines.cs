using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 以默认编码逐行读取文件内容。
        /// </summary>
        /// <param name="this">要读取的 <see cref="FileInfo"/> 实例。</param>
        /// <returns>文件的所有行的枚举集合。</returns>
        public static IEnumerable<string> ReadLines(this FileInfo @this)
        {
            return File.ReadLines(@this.FullName);
        }

        /// <summary>
        /// 以指定编码逐行读取文件内容。
        /// </summary>
        /// <param name="this">要读取的 <see cref="FileInfo"/> 实例。</param>
        /// <param name="encoding">用于读取文件的编码。</param>
        /// <returns>文件的所有行的枚举集合。</returns>
        public static IEnumerable<string> ReadLines(this FileInfo @this, Encoding encoding)
        {
            return File.ReadLines(@this.FullName, encoding);
        }
    }
}
