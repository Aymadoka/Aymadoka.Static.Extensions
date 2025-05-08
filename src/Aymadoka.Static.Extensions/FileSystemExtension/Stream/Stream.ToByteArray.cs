using System.IO;
using System.Text;

namespace Aymadoka.Static.StreamExtension
{
    public static partial class StreamExtensions
    {
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
