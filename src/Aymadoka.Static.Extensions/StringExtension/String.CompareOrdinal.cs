namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 按序号比较两个指定的字符串，并返回一个整数，指示它们在排序顺序中的相对位置。
        /// </summary>
        /// <param name="strA">第一个要比较的字符串。</param>
        /// <param name="strB">第二个要比较的字符串。</param>
        /// <returns>
        /// 一个 32 位带符号整数，指示两个字符串在排序顺序中的相对位置。
        /// 小于零：strA 小于 strB。
        /// 零：strA 等于 strB。
        /// 大于零：strA 大于 strB。
        /// </returns>
        public static int CompareOrdinal(this string strA, string strB)
        {
            return string.CompareOrdinal(strA, strB);
        }

        /// <summary>
        /// 按序号比较两个指定的子字符串，并返回一个整数，指示它们在排序顺序中的相对位置。
        /// </summary>
        /// <param name="strA">第一个要比较的字符串。</param>
        /// <param name="indexA">strA 中要比较的子字符串的起始索引。</param>
        /// <param name="strB">第二个要比较的字符串。</param>
        /// <param name="indexB">strB 中要比较的子字符串的起始索引。</param>
        /// <param name="length">要比较的最大字符数。</param>
        /// <returns>
        /// 一个 32 位带符号整数，指示两个子字符串在排序顺序中的相对位置。
        /// 小于零：strA 的子字符串小于 strB 的子字符串。
        /// 零：strA 的子字符串等于 strB 的子字符串。
        /// 大于零：strA 的子字符串大于 strB 的子字符串。
        /// </returns>
        public static int CompareOrdinal(this string strA, int indexA, string strB, int indexB, int length)
        {
            return string.CompareOrdinal(strA, indexA, strB, indexB, length);
        }
    }
}
