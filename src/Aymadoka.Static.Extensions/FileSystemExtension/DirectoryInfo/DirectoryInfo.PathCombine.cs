using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        /// <summary>
        /// 将当前 <see cref="DirectoryInfo"/> 的完整路径与指定的路径片段组合成一个路径。
        /// </summary>
        /// <param name="this">要作为基础路径的 <see cref="DirectoryInfo"/> 实例。</param>
        /// <param name="paths">要组合的一个或多个路径片段。</param>
        /// <returns>组合后的完整路径字符串。</returns>
        public static string PathCombine(this DirectoryInfo @this, params string[] paths)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            var list = paths.ToList();
            list.Insert(0, @this.FullName);

            return Path.Combine(list.ToArray());
        }
    }
}
