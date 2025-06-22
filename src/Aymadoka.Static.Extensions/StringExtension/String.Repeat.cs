using System;
using System.Text;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 为字符串扩展方法，返回当前字符串重复指定次数后的新字符串。
        /// </summary>
        /// <param name="this">要重复的字符串。</param>
        /// <param name="repeatCount">重复次数。</param>
        /// <returns>重复后的新字符串。</returns>
        /// <exception cref="ArgumentNullException">当字符串为 null 时抛出。</exception>
        /// <exception cref="ArgumentOutOfRangeException">当重复次数小于 0 时抛出。</exception>
        public static string Repeat(this string @this, int repeatCount)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            if (repeatCount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(repeatCount));
            }

            if (@this.Length == 1)
            {
                return new string(@this[0], repeatCount);
            }

            var sb = new StringBuilder(repeatCount * @this.Length);
            while (repeatCount-- > 0)
            {
                sb.Append(@this);
            }

            return sb.ToString();
        }
    }
}
