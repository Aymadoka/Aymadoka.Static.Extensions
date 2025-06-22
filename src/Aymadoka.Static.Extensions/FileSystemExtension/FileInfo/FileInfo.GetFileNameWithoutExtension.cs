using System;
using System.IO;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 获取不带扩展名的文件名。
        /// </summary>
        /// <param name="this">要获取文件名的 <see cref="FileInfo"/> 实例。</param>
        /// <returns>不带扩展名的文件名字符串。</returns>
        public static string GetFileNameWithoutExtension(this FileInfo @this)
        {
            return Path.GetFileNameWithoutExtension(@this.FullName);
        }
    }
}
