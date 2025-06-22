using System;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 统计文件中的总行数。
        /// </summary>
        /// <param name="this">要统计的 <see cref="FileInfo"/> 实例。</param>
        /// <returns>文件的行数。</returns>
        public static int CountLines(this FileInfo @this)
        {
            return File.ReadAllLines(@this.FullName).Length;
        }

        /// <summary>
        /// 统计文件中满足指定条件的行数。
        /// </summary>
        /// <param name="this">要统计的 <see cref="FileInfo"/> 实例。</param>
        /// <param name="predicate">用于判断每一行是否计入统计的条件。</param>
        /// <returns>满足条件的行数。</returns>
        public static int CountLines(this FileInfo @this, Func<string, bool> predicate)
        {
            return File.ReadAllLines(@this.FullName).Count(predicate);
        }
    }
}
