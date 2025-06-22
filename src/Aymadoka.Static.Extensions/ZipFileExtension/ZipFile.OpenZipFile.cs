using System.IO;
using System.IO.Compression;
using System.Text;

namespace Aymadoka.Static.ZipFileExtension
{
    public static partial class ZipFileExtensions
    {
        /// <summary>
        /// 以指定的 <see cref="ZipArchiveMode"/> 模式打开指定的 Zip 文件。
        /// </summary>
        /// <param name="this">要打开的 <see cref="FileInfo"/> 实例。</param>
        /// <param name="mode">Zip 文件的打开模式。</param>
        /// <returns>返回 <see cref="ZipArchive"/> 实例。</returns>
        public static ZipArchive OpenZipFile(this FileInfo @this, ZipArchiveMode mode)
        {
            return ZipFile.Open(@this.FullName, mode);
        }

        /// <summary>
        /// 以指定的 <see cref="ZipArchiveMode"/> 模式和条目名称编码打开指定的 Zip 文件。
        /// </summary>
        /// <param name="this">要打开的 <see cref="FileInfo"/> 实例。</param>
        /// <param name="mode">Zip 文件的打开模式。</param>
        /// <param name="entryNameEncoding">Zip 条目名称的编码。</param>
        /// <returns>返回 <see cref="ZipArchive"/> 实例。</returns>
        public static ZipArchive OpenZipFile(this FileInfo @this, ZipArchiveMode mode, Encoding entryNameEncoding)
        {
            return ZipFile.Open(@this.FullName, mode, entryNameEncoding);
        }
    }
}
