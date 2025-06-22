using System.IO;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        /// <summary>
        /// 创建所有不存在的目录和子目录。
        /// </summary>
        /// <param name="this">要创建的目录信息。</param>
        /// <returns>表示已创建目录的 <see cref="DirectoryInfo"/> 实例。</returns>
        public static DirectoryInfo CreateAllDirectories(this DirectoryInfo @this)
        {
            return Directory.CreateDirectory(@this.FullName);
        }
    }
}
