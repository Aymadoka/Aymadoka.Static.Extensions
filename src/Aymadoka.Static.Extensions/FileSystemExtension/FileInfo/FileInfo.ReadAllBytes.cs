using System;
using System.IO;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 读取指定 <see cref="FileInfo"/> 表示的文件的所有字节。
        /// </summary>
        /// <param name="this">要读取的文件信息对象。</param>
        /// <returns>包含文件所有字节的字节数组。</returns>
        public static byte[] ReadAllBytes(this FileInfo @this)
        {
            return File.ReadAllBytes(@this.FullName);
        }
    }
}
