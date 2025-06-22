using System.IO;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 为指定的 <see cref="FileInfo"/> 创建其所在目录（如果目录不存在则创建）。
        /// </summary>
        /// <param name="this">目标 <see cref="FileInfo"/> 实例。</param>
        /// <returns>创建或已存在的 <see cref="DirectoryInfo"/> 实例。</returns>
        public static DirectoryInfo CreateDirectory(this FileInfo @this)
        {
            return Directory.CreateDirectory(@this.Directory.FullName);
        }
    }
}
