using System.IO;

namespace Aymadoka.Static.ByteArrayExtension
{
    public static partial class ByteArrayExtensions
    {
        public static MemoryStream ToMemoryStream(this byte[] @this)
        {
            return new MemoryStream(@this);
        }
    }
}
