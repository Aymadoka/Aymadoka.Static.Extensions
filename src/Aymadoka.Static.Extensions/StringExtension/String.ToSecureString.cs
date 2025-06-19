using System;
using System.Security;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 将当前字符串转换为 <see cref="SecureString"/>。
        /// </summary>
        /// <param name="this">要转换的字符串。</param>
        /// <returns>转换后的 <see cref="SecureString"/> 实例。</returns>
        public static SecureString ToSecureString(this string @this)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            var secureString = new SecureString();
            foreach (char c in @this)
            {
                secureString.AppendChar(c);
            }

            return secureString;
        }
    }
}
