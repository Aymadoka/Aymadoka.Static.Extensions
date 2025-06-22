using System;
using System.IO;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 获取指定 <see cref="FileInfo"/> 的路径根目录。
        /// </summary>
        /// <param name="this">要获取根目录的 <see cref="FileInfo"/> 实例。</param>
        /// <returns>文件路径的根目录字符串。</returns>
        public static string GetPathRoot(this FileInfo @this)
        {
            return Path.GetPathRoot(@this.FullName);
        }
    }
}
