using System.IO;
using System.Text;

namespace Aymadoka.Static.StreamExtension
{
    public static partial class StreamExtensions
    {
        /// <summary>
        /// 以默认编码（Encoding.Default）读取流中的所有文本内容。
        /// </summary>
        /// <param name="this">要读取的流。</param>
        /// <returns>流中的所有文本内容。</returns>
        public static string ReadToEnd(this Stream @this)
        {
            using (var sr = new StreamReader(@this, Encoding.Default))
            {
                return sr.ReadToEnd();
            }
        }

        /// <summary>
        /// 以指定编码读取流中的所有文本内容。
        /// </summary>
        /// <param name="this">要读取的流。</param>
        /// <param name="encoding">用于读取的编码。</param>
        /// <returns>流中的所有文本内容。</returns>
        public static string ReadToEnd(this Stream @this, Encoding encoding)
        {
            using (var sr = new StreamReader(@this, encoding))
            {
                return sr.ReadToEnd();
            }
        }

        /// <summary>
        /// 从指定位置开始，以默认编码（Encoding.Default）读取流中的所有文本内容。
        /// </summary>
        /// <param name="this">要读取的流。</param>
        /// <param name="position">开始读取的位置。</param>
        /// <returns>流中的所有文本内容。</returns>
        public static string ReadToEnd(this Stream @this, long position)
        {
            @this.Position = position;

            using (var sr = new StreamReader(@this, Encoding.Default))
            {
                return sr.ReadToEnd();
            }
        }

        /// <summary>
        /// 从指定位置开始，以指定编码读取流中的所有文本内容。
        /// </summary>
        /// <param name="this">要读取的流。</param>
        /// <param name="encoding">用于读取的编码。</param>
        /// <param name="position">开始读取的位置。</param>
        /// <returns>流中的所有文本内容。</returns>
        public static string ReadToEnd(this Stream @this, Encoding encoding, long position)
        {
            @this.Position = position;

            using (var sr = new StreamReader(@this, encoding))
            {
                return sr.ReadToEnd();
            }
        }
    }
}
