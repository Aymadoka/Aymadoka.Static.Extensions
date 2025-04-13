using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Aymadok.Static.Md5Extension
{
    public static class Md5Extensions
    {
        /// <summary>获取字符串的MD5哈希值</summary>
        /// <param name="value">输入字符串</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMd5(this string? value)
        {
            var result = value.ToMd5(EnumMd5Format.x2);
            return result;
        }

        /// <summary>获取字节数组的MD5哈希值</summary>
        /// <param name="value">输入字符串</param>
        /// <param name="salt">盐</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMd5(this string? value, string? salt)
        {
            var result = value.ToMd5(salt, EnumMd5Format.x2);
            return result;
        }

        /// <summary>获取字节数组的MD5哈希值</summary>
        /// <param name="value">输入字符串</param>
        /// <param name="format">格式</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMd5(this string? value, EnumMd5Format format)
        {
            var result = value.ToMd5(string.Empty, format);
            return result;
        }

        /// <summary>获取字节数组的MD5哈希值</summary>
        /// <param name="value">输入字符串</param>
        /// <param name="salt">盐</param>
        /// <param name="format">格式</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMd5(this string? value, string? salt, EnumMd5Format format)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "Cannot be empty.");
            }

            // 将盐值添加到输入字符串中
            byte[] bytes = Encoding.UTF8.GetBytes(value);
            var result = bytes.ToMd5(salt, format);
            return result;
        }

        /// <summary>获取字节数组的MD5哈希值</summary>
        /// <param name="value">输入字节数组</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMd5(this byte[]? value)
        {
            return value.ToMd5(string.Empty, EnumMd5Format.x2);
        }

        /// <summary>获取字节数组的MD5哈希值</summary>
        /// <param name="value">输入字节数组</param>
        /// <param name="salt">盐</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMd5(this byte[]? value, string? salt)
        {
            return value.ToMd5(salt, EnumMd5Format.x2);
        }

        /// <summary>获取字节数组的MD5哈希值</summary>
        /// <param name="value">输入字节数组</param>
        /// <param name="format">格式</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMd5(this byte[]? value, EnumMd5Format format)
        {
            return value.ToMd5(string.Empty, format);
        }

        /// <summary>获取字节数组的MD5哈希值</summary>
        /// <param name="value">输入字节数组</param>
        /// <param name="salt">盐</param>
        /// <param name="format">格式</param>
        /// <returns>MD5哈希值</returns>
        public static string ToMd5(this byte[]? value, string? salt, EnumMd5Format format)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "Cannot be empty.");
            }

            salt ??= string.Empty;
            var md5Format = format.ToString();

            // 将盐值添加到输入字节数组中
            byte[] saltBytes = Encoding.UTF8.GetBytes(salt);
            byte[] saltedValue = new byte[saltBytes.Length + value.Length];
            Buffer.BlockCopy(saltBytes, 0, saltedValue, 0, saltBytes.Length);
            Buffer.BlockCopy(value, 0, saltedValue, saltBytes.Length, value.Length);

            using MD5 md5 = MD5.Create();
            byte[] hashBytes = md5.ComputeHash(saltedValue);

            // 使用 string.Join 生成哈希值字符串
            var result = string.Join(string.Empty, hashBytes.Select(b => b.ToString(md5Format)));
            return result;
        }
    }
}
