using System;
using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 替换字符串中最后一个出现的指定子字符串。
        /// </summary>
        /// <param name="this">原始字符串。</param>
        /// <param name="oldValue">要被替换的子字符串。</param>
        /// <param name="newValue">用于替换的新子字符串。</param>
        /// <returns>替换后的字符串。如果未找到 <paramref name="oldValue"/>，则返回原始字符串。</returns>
        public static string ReplaceLast(this string @this, string oldValue, string newValue)
        {
            int startindex = @this.LastIndexOf(oldValue);

            if (startindex == -1)
            {
                return @this;
            }

            return @this.Remove(startindex, oldValue.Length).Insert(startindex, newValue);
        }
    }
}
