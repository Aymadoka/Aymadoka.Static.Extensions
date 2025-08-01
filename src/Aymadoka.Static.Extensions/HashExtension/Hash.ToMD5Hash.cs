using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Aymadoka.Static.HashExtension
{
    public static partial class MD5Extensions
    {
        /// <summary>获取字符串的MD5哈希值</summary> 
        /// <param name="value">输入字符串</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMD5Hash(this string value)
        {
            var result = value.ToMD5Hash(EnumHashFormat.x2);
            return result;
        }

        /// <summary>获取字节数组的MD5哈希值</summary>
        /// <param name="value">输入字符串</param>
        /// <param name="salt">盐</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMD5Hash(this string value, string salt)
        {
            var result = value.ToMD5Hash(salt, EnumHashFormat.x2);
            return result;
        }

        /// <summary>获取字节数组的MD5哈希值</summary>
        /// <param name="value">输入字符串</param>
        /// <param name="format">格式</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMD5Hash(this string value, EnumHashFormat format)
        {
            var result = value.ToMD5Hash(string.Empty, format);
            return result;
        }

        /// <summary>获取字节数组的MD5哈希值</summary>
        /// <param name="value">输入字符串</param>
        /// <param name="salt">盐</param>
        /// <param name="format">格式</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMD5Hash(this string value, string salt, EnumHashFormat format)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            // 将盐值添加到输入字符串中
            byte[] bytes = Encoding.UTF8.GetBytes(value);
            var result = bytes.ToMD5Hash(salt, format);
            return result;
        }

        /// <summary>
        /// 获取流的MD5哈希值，默认格式为小写双字符（x2）。
        /// </summary>
        /// <param name="this">输入流</param>
        /// <returns>MD5哈希值字符串</returns>
        public static string ToMD5Hash(this Stream @this)
        {
            return @this.ToMD5Hash(EnumHashFormat.x2);
        }

        /// <summary>
        /// 获取流的MD5哈希值，支持指定哈希字符串格式。
        /// </summary>
        /// <param name="this">输入流</param>
        /// <param name="format">哈希字符串格式</param>
        /// <returns>MD5哈希值字符串</returns>
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

        /// <summary>获取字节数组的MD5哈希值</summary>
        /// <param name="value">输入字节数组</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMD5Hash(this byte[] value)
        {
            return value.ToMD5Hash(string.Empty, EnumHashFormat.x2);
        }

        /// <summary>获取字节数组的MD5哈希值</summary>
        /// <param name="value">输入字节数组</param>
        /// <param name="salt">盐</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMD5Hash(this byte[] value, string salt)
        {
            return value.ToMD5Hash(salt, EnumHashFormat.x2);
        }

        /// <summary>获取字节数组的MD5哈希值</summary>
        /// <param name="value">输入字节数组</param>
        /// <param name="format">格式</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMD5Hash(this byte[] value, EnumHashFormat format)
        {
            return value.ToMD5Hash(string.Empty, format);
        }

        /// <summary>获取字节数组的MD5哈希值</summary>
        /// <param name="value">输入字节数组</param>
        /// <param name="salt">盐</param>
        /// <param name="format">格式</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMD5Hash(this byte[] value, string salt, EnumHashFormat format)
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

            using (var md5 = MD5.Create())
            {
                // 计算 MD5 哈希值，返回一个 byte 数组
                var hashBytes = md5.ComputeHash(saltedValue);

                // 使用 string.Join 生成哈希值字符串
                string md5Format = format.ToString();
                string result = string.Join(string.Empty, hashBytes.Select(b => b.ToString(md5Format)));

                return result;
            }
        }
    }
}
