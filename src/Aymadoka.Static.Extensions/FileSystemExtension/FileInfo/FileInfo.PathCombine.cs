using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 将字符串集合中的所有路径片段合并为一个完整的路径。
        /// </summary>
        /// <param name="this">要合并的路径片段集合。</param>
        /// <returns>合并后的完整路径字符串。</returns>
        public static string PathCombine(this IEnumerable<string> @this)
        {
            return Path.Combine(@this.ToArray());
        }
    }
}
