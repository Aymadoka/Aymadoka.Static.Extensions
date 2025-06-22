using System.IO;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        /// <summary>
        /// 确保指定的目录存在。如果目录不存在，则创建它。
        /// </summary>
        /// <param name="this">要检查或创建的 <see cref="DirectoryInfo"/> 实例。</param>
        /// <returns>已存在或新创建的 <see cref="DirectoryInfo"/> 实例。</returns>
        public static DirectoryInfo EnsureDirectoryExists(this DirectoryInfo @this)
        {
            return Directory.CreateDirectory(@this.FullName);
        }
    }
}
