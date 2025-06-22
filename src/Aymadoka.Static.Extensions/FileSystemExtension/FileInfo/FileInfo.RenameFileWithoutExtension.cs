using System.IO;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 重命名文件（不改变扩展名）。
        /// </summary>
        /// <param name="this">要重命名的 <see cref="FileInfo"/> 实例。</param>
        /// <param name="newName">新的文件名（不包含扩展名）。</param>
        public static void RenameFileWithoutExtension(this FileInfo @this, string newName)
        {
            // 拼接新文件名（保留原扩展名）
            string fileName = string.Concat(newName, @this.Extension);
            // 生成新文件的完整路径
            string filePath = Path.Combine(@this.Directory.FullName, fileName);
            // 移动（重命名）文件
            @this.MoveTo(filePath);
        }
    }
}
