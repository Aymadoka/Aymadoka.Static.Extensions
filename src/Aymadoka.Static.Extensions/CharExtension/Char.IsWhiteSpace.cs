using System.Globalization;
using System;

namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        /// <summary>
        /// 判断指定的字符是否为空白字符。
        /// </summary>
        /// <param name="c">要检查的字符。</param>
        /// <returns>如果字符是空白字符，则为 <c>true</c>；否则为 <c>false</c>。</returns>
        public static bool IsWhiteSpace(this char c)
        {
            return char.IsWhiteSpace(c);
        }
    }
}
