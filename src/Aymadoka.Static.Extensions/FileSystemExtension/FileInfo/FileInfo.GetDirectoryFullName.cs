using System.IO;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 获取指定 <see cref="FileInfo"/> 所在目录的完整路径。
        /// </summary>
        /// <param name="this">要获取目录路径的 <see cref="FileInfo"/> 实例。</param>
        /// <returns>文件所在目录的完整路径。</returns>
        public static string GetDirectoryFullName(this FileInfo @this)
        {
            return @this.Directory.FullName;
        }
    }
}
