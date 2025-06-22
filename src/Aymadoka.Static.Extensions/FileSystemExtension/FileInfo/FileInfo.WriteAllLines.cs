using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 将字符串数组的所有行写入指定文件，使用默认编码。
        /// </summary>
        /// <param name="this">目标文件。</param>
        /// <param name="contents">要写入文件的字符串数组。</param>
        public static void WriteAllLines(this FileInfo @this, String[] contents)
        {
            File.WriteAllLines(@this.FullName, contents);
        }

        /// <summary>
        /// 将字符串数组的所有行写入指定文件，使用指定编码。
        /// </summary>
        /// <param name="this">目标文件。</param>
        /// <param name="contents">要写入文件的字符串数组。</param>
        /// <param name="encoding">用于写入文件的编码。</param>
        public static void WriteAllLines(this FileInfo @this, String[] contents, Encoding encoding)
        {
            File.WriteAllLines(@this.FullName, contents, encoding);
        }

        /// <summary>
        /// 将字符串集合的所有行写入指定文件，使用默认编码。
        /// </summary>
        /// <param name="this">目标文件。</param>
        /// <param name="contents">要写入文件的字符串集合。</param>
        public static void WriteAllLines(this FileInfo @this, IEnumerable<String> contents)
        {
            File.WriteAllLines(@this.FullName, contents);
        }

        /// <summary>
        /// 将字符串集合的所有行写入指定文件，使用指定编码。
        /// </summary>
        /// <param name="this">目标文件。</param>
        /// <param name="contents">要写入文件的字符串集合。</param>
        /// <param name="encoding">用于写入文件的编码。</param>
        public static void WriteAllLines(this FileInfo @this, IEnumerable<String> contents, Encoding encoding)
        {
            File.WriteAllLines(@this.FullName, contents, encoding);
        }
    }
}
