using System.IO;
using System.Text;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        /// <summary>
        /// 以默认编码读取整个文件内容。
        /// </summary>
        /// <param name="this">要读取的 <see cref="FileInfo"/> 实例。</param>
        /// <returns>文件的全部文本内容。</returns>
        public static string ReadToEnd(this FileInfo @this)
        {
            using (FileStream stream = File.Open(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (var reader = new StreamReader(stream, Encoding.Default))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        /// <summary>
        /// 以默认编码从指定位置开始读取文件内容。
        /// </summary>
        /// <param name="this">要读取的 <see cref="FileInfo"/> 实例。</param>
        /// <param name="position">文件流的起始读取位置。</param>
        /// <returns>从指定位置开始的文件文本内容。</returns>
        public static string ReadToEnd(this FileInfo @this, long position)
        {
            using (FileStream stream = File.Open(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                stream.Position = position;

                using (var reader = new StreamReader(stream, Encoding.Default))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        /// <summary>
        /// 以指定编码读取整个文件内容。
        /// </summary>
        /// <param name="this">要读取的 <see cref="FileInfo"/> 实例。</param>
        /// <param name="encoding">用于读取文件的编码。</param>
        /// <returns>文件的全部文本内容。</returns>
        public static string ReadToEnd(this FileInfo @this, Encoding encoding)
        {
            using (FileStream stream = File.Open(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (var reader = new StreamReader(stream, encoding))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        /// <summary>
        /// 以指定编码从指定位置开始读取文件内容。
        /// </summary>
        /// <param name="this">要读取的 <see cref="FileInfo"/> 实例。</param>
        /// <param name="encoding">用于读取文件的编码。</param>
        /// <param name="position">文件流的起始读取位置。</param>
        /// <returns>从指定位置开始的文件文本内容。</returns>
        public static string ReadToEnd(this FileInfo @this, Encoding encoding, long position)
        {
            using (FileStream stream = File.Open(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                stream.Position = position;

                using (var reader = new StreamReader(stream, encoding))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
