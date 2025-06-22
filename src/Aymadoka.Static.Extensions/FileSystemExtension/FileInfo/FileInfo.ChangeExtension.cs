using System;
using System.IO;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 更改指定 <see cref="FileInfo"/> 实例的文件扩展名。
        /// </summary>
        /// <param name="this">要更改扩展名的 <see cref="FileInfo"/> 实例。</param>
        /// <param name="extension">新扩展名（可以包含或不包含前导点“.”）。</param>
        /// <returns>更改扩展名后的完整文件路径字符串。</returns>
        public static string ChangeExtension(this FileInfo @this, string extension)
        {
            return Path.ChangeExtension(@this.FullName, extension);
        }
    }
}
