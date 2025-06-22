using System.IO;
using System.IO.Compression;

namespace Aymadoka.Static.ZipFileExtension
{
    public static partial class ZipFileExtensions
    {
        /// <summary>
        /// 以只读方式打开指定的 <see cref="FileInfo"/> 表示的 zip 文件，并返回 <see cref="ZipArchive"/> 实例。
        /// </summary>
        /// <param name="this">要打开的 zip 文件。</param>
        /// <returns>只读模式下的 <see cref="ZipArchive"/> 实例。</returns>
        public static ZipArchive OpenReadZipFile(this FileInfo @this)
        {
            return ZipFile.OpenRead(@this.FullName);
        }
    }
}
