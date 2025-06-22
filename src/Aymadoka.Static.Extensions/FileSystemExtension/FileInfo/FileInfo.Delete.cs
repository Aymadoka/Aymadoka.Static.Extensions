using System.Collections.Generic;
using System.IO;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 删除 <see cref="IEnumerable{FileInfo}"/> 集合中的所有文件。
        /// </summary>
        /// <param name="this">要删除的 <see cref="FileInfo"/> 集合。</param>
        public static void Delete(this IEnumerable<FileInfo> @this)
        {
            foreach (FileInfo t in @this)
            {
                t.Delete();
            }
        }
    }
}
