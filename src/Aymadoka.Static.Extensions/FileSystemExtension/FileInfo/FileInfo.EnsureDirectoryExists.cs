using System;
using System.IO;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 确保 <see cref="FileInfo"/> 对象所在的目录存在。
        /// 如果目录不存在，则创建该目录。
        /// </summary>
        /// <param name="this">要检查目录的 <see cref="FileInfo"/> 实例。</param>
        /// <returns>目录的 <see cref="DirectoryInfo"/> 实例。</returns>
        public static DirectoryInfo EnsureDirectoryExists(this FileInfo @this)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            return Directory.CreateDirectory(@this.Directory.FullName);
        }
    }
}
