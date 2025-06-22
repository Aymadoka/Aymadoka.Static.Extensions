using System;
using System.IO;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 获取指定 <see cref="FileInfo"/> 实例所在目录的名称。
        /// </summary>
        /// <param name="this">要获取目录名称的 <see cref="FileInfo"/> 实例。</param>
        /// <returns>文件所在目录的名称。</returns>
        public static string GetDirectoryName(this FileInfo @this)
        {
            return @this.Directory.Name;
        }
    }
}
