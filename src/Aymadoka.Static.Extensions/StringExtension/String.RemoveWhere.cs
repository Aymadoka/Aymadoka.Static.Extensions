using System;
using System.Linq;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 移除字符串中满足指定条件的所有字符。
        /// </summary>
        /// <param name="this">要处理的字符串。</param>
        /// <param name="predicate">用于判断字符是否应被移除的条件委托。</param>
        /// <returns>移除满足条件字符后的新字符串。</returns>
        public static string RemoveWhere(this string @this, Func<char, bool> predicate)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            var result = new string(@this.ToCharArray().Where(x => predicate == null || !predicate(x)).ToArray());
            return result;
        }
    }
}
