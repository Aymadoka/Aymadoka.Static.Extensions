using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Aymadoka.Static.HashExtension
{
    public static class Md5Extensions
    {
        /// <summary>获取字符串的MD5哈希值</summary>
        /// <param name="value">输入字符串</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMd5Hash(this string value)
        {
            var result = value.ToMd5Hash(EnumHashFormat.x2);
            return result;
        }

        /// <summary>获取字节数组的MD5哈希值</summary>
        /// <param name="value">输入字符串</param>
        /// <param name="salt">盐</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMd5Hash(this string value, string salt)
        {
            var result = value.ToMd5Hash(salt, EnumHashFormat.x2);
            return result;
        }

        /// <summary>获取字节数组的MD5哈希值</summary>
        /// <param name="value">输入字符串</param>
        /// <param name="format">格式</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMd5Hash(this string value, EnumHashFormat format)
        {
            var result = value.ToMd5Hash(string.Empty, format);
            return result;
        }

        /// <summary>获取字节数组的MD5哈希值</summary>
        /// <param name="value">输入字符串</param>
        /// <param name="salt">盐</param>
        /// <param name="format">格式</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMd5Hash(this string value, string salt, EnumHashFormat format)
        {
            ArgumentNullException.ThrowIfNull(value);

            // 将盐值添加到输入字符串中
            byte[] bytes = Encoding.UTF8.GetBytes(value);
            var result = bytes.ToMd5Hash(salt, format);
            return result;
        }

        /// <summary>获取字节数组的MD5哈希值</summary>
        /// <param name="value">输入字节数组</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMd5Hash(this byte[] value)
        {
            return value.ToMd5Hash(string.Empty, EnumHashFormat.x2);
        }

        /// <summary>获取字节数组的MD5哈希值</summary>
        /// <param name="value">输入字节数组</param>
        /// <param name="salt">盐</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMd5Hash(this byte[] value, string salt)
        {
            return value.ToMd5Hash(salt, EnumHashFormat.x2);
        }

        /// <summary>获取字节数组的MD5哈希值</summary>
        /// <param name="value">输入字节数组</param>
        /// <param name="format">格式</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMd5Hash(this byte[] value, EnumHashFormat format)
        {
            return value.ToMd5Hash(string.Empty, format);
        }

        /// <summary>获取字节数组的MD5哈希值</summary>
        /// <param name="value">输入字节数组</param>
        /// <param name="salt">盐</param>
        /// <param name="format">格式</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMd5Hash(this byte[] value, string salt, EnumHashFormat format)
        {
            ArgumentNullException.ThrowIfNull(value);

            salt ??= string.Empty;

            // 将盐值添加到输入字节数组中
            byte[] saltBytes = Encoding.UTF8.GetBytes(salt);
            byte[] saltedValue = new byte[saltBytes.Length + value.Length];
            Buffer.BlockCopy(saltBytes, 0, saltedValue, 0, saltBytes.Length);
            Buffer.BlockCopy(value, 0, saltedValue, saltBytes.Length, value.Length);

            byte[] hashBytes = MD5.HashData(saltedValue);

            // 使用 string.Join 生成哈希值字符串
            string md5Format = format.ToString();
            string result = string.Join(string.Empty, hashBytes.Select(b => b.ToString(md5Format)));

            return result;
        }
    }
}
