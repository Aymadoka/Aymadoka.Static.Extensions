using System.IO;
using System.Linq;
using System.Security.Cryptography;
using Aymadoka.Static.HashExtension;

namespace Aymadoka.Static.StreamExtension
{
    public static partial class StreamExtensions
    {
        public static string ToMD5Hash(this Stream @this)
        {
            return @this.ToMD5Hash(EnumHashFormat.x2);
        }

        public static string ToMD5Hash(this Stream @this, EnumHashFormat format)
        {
            using (var md5 = MD5.Create())
            {
                // 计算 MD5 哈希值，返回一个 byte 数组
                var hashBytes = md5.ComputeHash(@this);

                // 使用 string.Join 生成哈希值字符串
                string md5Format = format.ToString();
                string result = string.Join(string.Empty, hashBytes.Select(b => b.ToString(md5Format)));

                return result;
            }
        }
    }
}
