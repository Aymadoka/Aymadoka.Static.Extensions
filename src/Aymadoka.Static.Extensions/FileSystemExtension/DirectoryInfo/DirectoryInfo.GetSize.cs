using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        /// <summary>
        /// 获取目录及其所有子目录下所有文件的总大小（以字节为单位）。
        /// </summary>
        /// <param name="this">要计算大小的目录。</param>
        /// <returns>目录及其所有子目录下所有文件的总大小（字节）。</returns>
        public static long GetSize(this DirectoryInfo @this)
        {
            // 获取所有文件并累加其长度
            return @this.GetFiles("*.*", SearchOption.AllDirectories).Sum(x => x.Length);
        }
    }
}
