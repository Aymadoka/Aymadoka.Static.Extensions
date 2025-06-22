using System;
using System.IO;
using System.Text;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 读取指定文件的所有行，使用默认编码。
        /// </summary>
        /// <param name="this">要读取的 <see cref="FileInfo"/> 实例。</param>
        /// <returns>包含文件所有行的字符串数组。</returns>
        public static string[] ReadAllLines(this FileInfo @this)
        {
            return File.ReadAllLines(@this.FullName);
        }

        /// <summary>
        /// 读取指定文件的所有行，使用指定的编码。
        /// </summary>
        /// <param name="this">要读取的 <see cref="FileInfo"/> 实例。</param>
        /// <param name="encoding">用于读取文件的编码。</param>
        /// <returns>包含文件所有行的字符串数组。</returns>
        public static string[] ReadAllLines(this FileInfo @this, Encoding encoding)
        {
            return File.ReadAllLines(@this.FullName, encoding);
        }
    }
}
