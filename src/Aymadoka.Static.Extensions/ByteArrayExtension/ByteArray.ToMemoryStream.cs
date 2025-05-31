using System.IO;

namespace Aymadoka.Static.ByteArrayExtension
{
    public static partial class ByteArrayExtensions
    {
        /// <summary>
        /// 将字节数组转换为 <see cref="MemoryStream"/>
        /// </summary>
        /// <param name="this">要转换的字节数组</param>
        /// <returns>包含字节数组数据的 <see cref="MemoryStream"/> 实例</returns>
        public static MemoryStream ToMemoryStream(this byte[] @this)
        {
            return new MemoryStream(@this);
        }
    }
}
