namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        /// <summary>
        /// 获取指定字符的数值表示形式。
        /// </summary>
        /// <param name="c">要获取数值的字符。</param>
        /// <returns>字符的数值表示形式；如果字符没有数值，则返回 -1。</returns>
        public static double GetNumericValue(this char c)
        {
            return char.GetNumericValue(c);
        }
    }
}
