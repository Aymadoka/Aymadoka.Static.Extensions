using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Aymadoka.Static.HashExtension
{
    public static partial class MD5Extensions
    {
        /// <summary>获取字符串的SHA256哈希值</summary> 
        /// <param name="value">输入字符串</param>
        /// <returns>SHA256哈希值</returns>
        public static string ToSHA256Hash(this string value)
        {
            var result = value.ToSHA256Hash(EnumHashFormat.x2);
            return result;
        }

        /// <summary>获取字符串的SHA256哈希值</summary>
        /// <param name="value">输入字符串</param>
        /// <param name="salt">盐</param>
        /// <returns>SHA256哈希值</returns>
        public static string ToSHA256Hash(this string value, string salt)
        {
            var result = value.ToSHA256Hash(salt, EnumHashFormat.x2);
            return result;
        }

        /// <summary>获取字符串的SHA256哈希值</summary>
        /// <param name="value">输入字符串</param>
        /// <param name="format">格式</param>
        /// <returns>SHA256哈希值</returns>
        public static string ToSHA256Hash(this string value, EnumHashFormat format)
        {
            var result = value.ToSHA256Hash(string.Empty, format);
            return result;
        }

        /// <summary>获取字符串的SHA256哈希值</summary>
        /// <param name="value">输入字符串</param>
        /// <param name="salt">盐</param>
        /// <param name="format">格式</param>
        /// <returns>SHA256哈希值</returns>
        public static string ToSHA256Hash(this string value, string salt, EnumHashFormat format)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            // 将盐值添加到输入字符串中
            byte[] bytes = Encoding.UTF8.GetBytes(value);
            var result = bytes.ToSHA256Hash(salt, format);
            return result;
        }

        /// <summary>
        /// 获取流的 SHA256 哈希值，默认格式为小写双字符（x2）。
        /// </summary>
        /// <param name="this">输入流</param>
        /// <returns>SHA256 哈希值字符串</returns>
        public static string ToSHA256Hash(this Stream @this)
        {
            return @this.ToSHA256Hash(EnumHashFormat.x2);
        }

        /// <summary>
        /// 获取流的 SHA256 哈希值，指定格式。
        /// </summary>
        /// <param name="this">输入流</param>
        /// <param name="format">哈希字符串格式</param>
        /// <returns>SHA256 哈希值字符串</returns>
        public static string ToSHA256Hash(this Stream @this, EnumHashFormat format)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            using (var sha256 = SHA256.Create())
            {
                // 计算 SHA256 哈希值，返回一个 byte 数组
                var hashBytes = sha256.ComputeHash(@this);

                // 使用 string.Join 生成哈希值字符串
                string md5Format = format.ToString();
                string result = string.Join(string.Empty, hashBytes.Select(b => b.ToString(md5Format)));
                return result;
            }
        }

        /// <summary>获取字节数组的SHA256哈希值</summary>
        /// <param name="value">输入字节数组</param>
        /// <returns>SHA256哈希值</returns>
        public static string ToSHA256Hash(this byte[] value)
        {
            return value.ToSHA256Hash(string.Empty, EnumHashFormat.x2);
        }

        /// <summary>获取字节数组的SHA256哈希值</summary>
        /// <param name="value">输入字节数组</param>
        /// <param name="salt">盐</param>
        /// <returns>SHA256哈希值</returns>
        public static string ToSHA256Hash(this byte[] value, string salt)
        {
            return value.ToSHA256Hash(salt, EnumHashFormat.x2);
        }

        /// <summary>获取字节数组的SHA256哈希值</summary>
        /// <param name="value">输入字节数组</param>
        /// <param name="format">格式</param>
        /// <returns>SHA256哈希值</returns>
        public static string ToSHA256Hash(this byte[] value, EnumHashFormat format)
        {
            return value.ToSHA256Hash(string.Empty, format);
        }

        /// <summary>获取字节数组的SHA256哈希值</summary>
        /// <param name="value">输入字节数组</param>
        /// <param name="salt">盐</param>
        /// <param name="format">格式</param>
        /// <returns>SHA256哈希值</returns>
        public static string ToSHA256Hash(this byte[] value, string salt, EnumHashFormat format)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            salt ??= string.Empty;

            // 将盐值添加到输入字节数组中
            byte[] saltBytes = Encoding.UTF8.GetBytes(salt);
            byte[] saltedValue = new byte[saltBytes.Length + value.Length];
            Buffer.BlockCopy(saltBytes, 0, saltedValue, 0, saltBytes.Length);
            Buffer.BlockCopy(value, 0, saltedValue, saltBytes.Length, value.Length);

            using (var sha256 = SHA256.Create())
            {
                // 计算 SHA256 哈希值，返回一个 byte 数组
                var hashBytes = sha256.ComputeHash(saltedValue);

                // 使用 string.Join 生成哈希值字符串
                string md5Format = format.ToString();
                string result = string.Join(string.Empty, hashBytes.Select(b => b.ToString(md5Format)));
                return result;
            }
        }
    }
}
