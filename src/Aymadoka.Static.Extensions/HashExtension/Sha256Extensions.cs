using Aymadoka.Static.EnumerableExtension;
using System.Security.Cryptography;
using System.Text;
using System;
using System.Linq;

namespace Aymadoka.Static.HashExtension
{
    public static class Sha256Extensions
    {
        /// <summary>获取字符串的SHA256哈希值</summary>
        /// <param name="value">输入字符串</param>
        /// <returns>SHA256哈希值</returns>
        public static string ToSha256Hash(this string value)
        {
            var result = value.ToSha256Hash(EnumHashFormat.x2);
            return result;
        }

        /// <summary>获取字符串的SHA256哈希值</summary>
        /// <param name="value">输入字符串</param>
        /// <param name="salt">盐</param>
        /// <returns>SHA256哈希值</returns>
        public static string ToSha256Hash(this string value, string salt)
        {
            var result = value.ToSha256Hash(salt, EnumHashFormat.x2);
            return result;
        }

        /// <summary>获取字符串的SHA256哈希值</summary>
        /// <param name="value">输入字符串</param>
        /// <param name="format">格式</param>
        /// <returns>SHA256哈希值</returns>
        public static string ToSha256Hash(this string value, EnumHashFormat format)
        {
            var result = value.ToSha256Hash(string.Empty, format);
            return result;
        }

        /// <summary>获取字符串的SHA256哈希值</summary>
        /// <param name="value">输入字符串</param>
        /// <param name="salt">盐</param>
        /// <param name="format">格式</param>
        /// <returns>SHA256哈希值</returns>
        public static string ToSha256Hash(this string value, string salt, EnumHashFormat format)
        {
            ArgumentNullException.ThrowIfNull(value);

            // 将盐值添加到输入字符串中
            byte[] bytes = Encoding.UTF8.GetBytes(value);
            var result = bytes.ToSha256Hash(salt, format);
            return result;
        }

        /// <summary>获取字节数组的SHA256哈希值</summary>
        /// <param name="value">输入字节数组</param>
        /// <returns>SHA256哈希值</returns>
        public static string ToSha256Hash(this byte[] value)
        {
            return value.ToSha256Hash(string.Empty, EnumHashFormat.x2);
        }

        /// <summary>获取字节数组的SHA256哈希值</summary>
        /// <param name="value">输入字节数组</param>
        /// <param name="salt">盐</param>
        /// <returns>SHA256哈希值</returns>
        public static string ToSha256Hash(this byte[] value, string salt)
        {
            return value.ToSha256Hash(salt, EnumHashFormat.x2);
        }

        /// <summary>获取字节数组的SHA256哈希值</summary>
        /// <param name="value">输入字节数组</param>
        /// <param name="format">格式</param>
        /// <returns>SHA256哈希值</returns>
        public static string ToSha256Hash(this byte[] value, EnumHashFormat format)
        {
            return value.ToSha256Hash(string.Empty, format);
        }

        /// <summary>获取字节数组的SHA256哈希值</summary>
        /// <param name="value">输入字节数组</param>
        /// <param name="salt">盐</param>
        /// <param name="format">格式</param>
        /// <returns>SHA256哈希值</returns>
        public static string ToSha256Hash(this byte[] value, string salt, EnumHashFormat format)
        {
            ArgumentNullException.ThrowIfNull(value);

            salt ??= string.Empty;

            // 将盐值添加到输入字节数组中
            byte[] saltBytes = Encoding.UTF8.GetBytes(salt);
            byte[] saltedValue = new byte[saltBytes.Length + value.Length];
            Buffer.BlockCopy(saltBytes, 0, saltedValue, 0, saltBytes.Length);
            Buffer.BlockCopy(value, 0, saltedValue, saltBytes.Length, value.Length);

            byte[] hashBytes = SHA256.HashData(saltedValue);

            // 使用 string.Join 生成哈希值字符串
            string md5Format = format.ToString();
            string result = string.Join(string.Empty, hashBytes.Select(b => b.ToString(md5Format)));

            return result;
        }
    }
}
