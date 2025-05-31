namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        /// <summary>
        /// 将代理项对（高代理项和低代理项）转换为其对应的 UTF-32 代码点。
        /// </summary>
        /// <param name="highSurrogate">高代理项字符（char）。</param>
        /// <param name="lowSurrogate">低代理项字符（char）。</param>
        /// <returns>对应的 UTF-32 代码点（int）。</returns>
        public static int ConvertToUtf32(this char highSurrogate, char lowSurrogate)
        {
            return char.ConvertToUtf32(highSurrogate, lowSurrogate);
        }
    }
}
