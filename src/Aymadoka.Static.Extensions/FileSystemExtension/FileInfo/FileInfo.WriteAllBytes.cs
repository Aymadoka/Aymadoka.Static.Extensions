using System;
using System.IO;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 将指定的字节数组写入到当前 <see cref="FileInfo"/> 表示的文件中。
        /// </summary>
        /// <param name="this">目标文件。</param>
        /// <param name="bytes">要写入文件的字节数组。</param>
        public static void WriteAllBytes(this FileInfo @this, Byte[] bytes)
        {
            File.WriteAllBytes(@this.FullName, bytes);
        }
    }
}
