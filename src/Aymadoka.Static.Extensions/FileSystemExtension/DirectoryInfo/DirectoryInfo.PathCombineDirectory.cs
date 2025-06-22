using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        /// <summary>
        /// 为 <see cref="DirectoryInfo"/> 实例与指定的路径片段组合生成新的 <see cref="DirectoryInfo"/> 实例。
        /// </summary>
        /// <param name="this">当前目录信息。</param>
        /// <param name="paths">要组合的路径片段。</param>
        /// <returns>组合后的 <see cref="DirectoryInfo"/> 实例。</returns>
        public static DirectoryInfo PathCombineDirectory(this DirectoryInfo @this, params string[] paths)
        {
            List<string> list = paths.ToList();
            list.Insert(0, @this.FullName);
            return new DirectoryInfo(Path.Combine(list.ToArray()));
        }
    }
}
