using System.Collections.Generic;
using System.IO;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        /// <summary>
        /// 删除 <see cref="IEnumerable{DirectoryInfo}"/> 集合中的所有目录。
        /// </summary>
        /// <param name="this">要删除的目录集合。</param>
        public static void Delete(this IEnumerable<DirectoryInfo> @this)
        {
            foreach (DirectoryInfo t in @this)
            {
                t.Delete();
            }
        }
    }
}
