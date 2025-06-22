using System;
using System.IO;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 判断指定的 <see cref="FileInfo"/> 路径是否为根路径。
        /// </summary>
        /// <param name="this">要检查的 <see cref="FileInfo"/> 实例。</param>
        /// <returns>如果路径为根路径，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsPathRooted(this FileInfo @this)
        {
            return Path.IsPathRooted(@this.FullName);
        }
    }
}
