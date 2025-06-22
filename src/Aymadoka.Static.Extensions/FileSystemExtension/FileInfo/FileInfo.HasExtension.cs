using System;
using System.IO;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 判断指定的 <see cref="FileInfo"/> 是否具有扩展名。
        /// </summary>
        /// <param name="this">要检查的 <see cref="FileInfo"/> 实例。</param>
        /// <returns>如果文件具有扩展名，则为 <c>true</c>；否则为 <c>false</c>。</returns>
        public static bool HasExtension(this FileInfo @this)
        {
            return Path.HasExtension(@this.FullName);
        }
    }
}
