using System;
using System.IO;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 将字符串路径转换为 <see cref="DirectoryInfo"/> 实例。
        /// </summary>
        /// <param name="this">目录路径字符串。</param>
        /// <returns>表示指定路径的 <see cref="DirectoryInfo"/> 实例。</returns>
        public static DirectoryInfo ToDirectoryInfo(this string @this)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            return new DirectoryInfo(@this);
        }
    }
}
