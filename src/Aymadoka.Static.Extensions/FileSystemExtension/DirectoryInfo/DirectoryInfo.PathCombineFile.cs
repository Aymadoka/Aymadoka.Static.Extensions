using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        /// <summary>
        /// 为 <see cref="DirectoryInfo"/> 实例与指定的路径片段组合生成 <see cref="FileInfo"/>。
        /// </summary>
        /// <param name="this">目录信息实例。</param>
        /// <param name="paths">要组合的路径片段。</param>
        /// <returns>组合后的 <see cref="FileInfo"/> 实例。</returns>
        public static FileInfo PathCombineFile(this DirectoryInfo @this, params string[] paths)
        {
            List<string> list = paths.ToList();
            list.Insert(0, @this.FullName);
            return new FileInfo(Path.Combine(list.ToArray()));
        }
    }
}
