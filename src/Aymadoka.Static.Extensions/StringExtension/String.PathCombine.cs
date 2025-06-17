using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 将当前字符串与一个或多个路径片段组合成一个完整路径。
        /// </summary>
        /// <param name="this">基础路径字符串。</param>
        /// <param name="paths">要组合的其他路径片段。</param>
        /// <returns>组合后的完整路径字符串。</returns>
        public static string PathCombine(this string @this, params string[] paths)
        {
            List<string> list = paths.ToList();
            list.Insert(0, @this);
            return Path.Combine(list.ToArray());
        }
    }
}
