using System;
using System.IO;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 为 <see cref="FileInfo"/> 实例重命名扩展名。
        /// </summary>
        /// <param name="this">要更改扩展名的 <see cref="FileInfo"/> 实例。</param>
        /// <param name="extension">新的扩展名（可以包含或不包含前导点）。</param>
        public static void RenameExtension(this FileInfo @this, String extension)
        {
            // 使用 Path.ChangeExtension 更改文件扩展名，生成新文件路径
            string filePath = Path.ChangeExtension(@this.FullName, extension);
            // 移动文件到新路径，实现扩展名重命名
            @this.MoveTo(filePath);
        }
    }
}
