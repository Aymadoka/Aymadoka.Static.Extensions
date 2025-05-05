using System.IO;
using System.IO.Compression;
using System.Text;

namespace Aymadoka.Static.GZipExtension;

public static partial class GZipExtensions
{
    public static byte[] CompressGZip(this string @this)
    {
        byte[] stringAsBytes = Encoding.Default.GetBytes(@this);
        using (var memoryStream = new MemoryStream())
        {
            using (var zipStream = new GZipStream(memoryStream, CompressionMode.Compress))
            {
                zipStream.Write(stringAsBytes, 0, stringAsBytes.Length);
                zipStream.Close();
                return (memoryStream.ToArray());
            }
        }
    }

    public static byte[] CompressGZip(this string @this, Encoding encoding)
    {
        byte[] stringAsBytes = encoding.GetBytes(@this);
        using (var memoryStream = new MemoryStream())
        {
            using (var zipStream = new GZipStream(memoryStream, CompressionMode.Compress))
            {
                zipStream.Write(stringAsBytes, 0, stringAsBytes.Length);
                zipStream.Close();
                return (memoryStream.ToArray());
            }
        }
    }
}
