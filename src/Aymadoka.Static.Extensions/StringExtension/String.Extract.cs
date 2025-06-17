using System;
using System.Linq;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
    /// <summary>
    /// 从字符串中提取所有满足指定条件的字符，并组成新的字符串。
    /// </summary>
    /// <param name="this">要处理的字符串。</param>
    /// <param name="predicate">用于判断字符是否被提取的条件委托。</param>
    /// <returns>包含所有满足条件字符的新字符串。</returns>
        public static string Extract(this string @this, Func<char, bool> predicate)
        {
            return new string(@this.ToCharArray().Where(predicate).ToArray());
        }
    }
}
