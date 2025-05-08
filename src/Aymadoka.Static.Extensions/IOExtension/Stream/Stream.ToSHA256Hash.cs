using Aymadoka.Static.HashExtension;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace Aymadoka.Static.StreamExtension;

public static partial class StreamExtensions
{
    public static string ToSHA256Hash(this Stream @this)
    {
        return @this.ToSHA256Hash(EnumHashFormat.x2);
    }

    public static string ToSHA256Hash(this Stream @this, EnumHashFormat format)
    {
        var hashBytes = SHA256.HashData(@this);

        // 使用 string.Join 生成哈希值字符串
        string md5Format = format.ToString();
        string result = string.Join(string.Empty, hashBytes.Select(b => b.ToString(md5Format)));

        return result;
    }
}
