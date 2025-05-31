using System;

namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        /// <summary>
        /// 判断指定字符是否为控制字符。
        /// </summary>
        /// <param name="c">要判断的字符。</param>
        /// <returns>如果字符为控制字符，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsControl(this char c)
        {
            return char.IsControl(c);
        }
    }
}
