using System.IO;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 重命名当前 <see cref="FileInfo"/> 表示的文件为指定的新文件名。
        /// </summary>
        /// <param name="this">要重命名的 <see cref="FileInfo"/> 实例。</param>
        /// <param name="newName">新的文件名（不包含路径）。</param>
        /// <exception cref="IOException">如果目标文件已存在，或发生 I/O 错误。</exception>
        public static void Rename(this FileInfo @this, string newName)
        {
            string filePath = Path.Combine(@this.Directory.FullName, newName);
            @this.MoveTo(filePath);
        }
    }
}
