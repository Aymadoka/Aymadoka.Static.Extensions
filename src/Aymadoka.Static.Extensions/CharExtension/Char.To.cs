using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        /// <summary>
        /// 生成一个字符序列，从当前字符到指定的字符（包含两端）。
        /// 如果当前字符大于目标字符，则结果为降序排列。
        /// </summary>
        /// <param name="this">起始字符。</param>
        /// <param name="toCharacter">结束字符。</param>
        /// <returns>包含从起始字符到结束字符的字符序列。</returns>
        public static IEnumerable<char> To(this char @this, char toCharacter)
        {
            bool reverseRequired = (@this > toCharacter);

            char first = reverseRequired ? toCharacter : @this;
            char last = reverseRequired ? @this : toCharacter;

            IEnumerable<char> result = Enumerable.Range(first, last - first + 1).Select(charCode => (char)charCode);

            if (reverseRequired)
            {
                result = result.Reverse();
            }

            return result;
        }
    }
}
