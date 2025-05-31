using System;

namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        /// <summary>
        /// 返回一个由指定字符重复指定次数组成的新字符串。
        /// </summary>
        /// <param name="this">要重复的字符。</param>
        /// <param name="repeatCount">重复次数。</param>
        /// <returns>由指定字符重复指定次数组成的新字符串。</returns>
        /// <exception cref="ArgumentOutOfRangeException">如果 <paramref name="repeatCount"/> 小于零，则抛出异常。</exception>
        public static string Repeat(this char @this, int repeatCount)
        {
            return new string(@this, repeatCount);
        }
    }
}
