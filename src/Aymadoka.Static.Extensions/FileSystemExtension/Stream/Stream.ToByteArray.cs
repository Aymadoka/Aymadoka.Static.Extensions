using System.IO;

namespace Aymadoka.Static.StreamExtension
{
    public static partial class StreamExtensions
    {
        /// <summary>
        /// 将 <see cref="Stream"/> 的内容读取为字节数组。
        /// </summary>
        /// <param name="this">要读取的流。</param>
        /// <returns>包含流内容的字节数组。</returns>
        public static byte[] ToByteArray(this Stream @this)
        {
            using (var ms = new MemoryStream())
            {
                @this.CopyTo(ms);
                return ms.ToArray();
            }
        }
    }
}
