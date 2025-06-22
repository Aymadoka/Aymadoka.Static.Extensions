using System.Text;

namespace Aymadoka.Static.StringBuilderExtension
{
    public static partial class StringBuilderExtensions
    {
        /// <summary>
        /// 从指定的起始索引处截取 <see cref="StringBuilder"/> 的子字符串，直到末尾。
        /// </summary>
        /// <param name="this">要操作的 <see cref="StringBuilder"/> 实例。</param>
        /// <param name="startIndex">子字符串的起始索引。</param>
        /// <returns>从起始索引到末尾的字符串。</returns>
        public static string Substring(this StringBuilder @this, int startIndex)
        {
            return @this.ToString(startIndex, @this.Length - startIndex);
        }

        /// <summary>
        /// 从指定的起始索引处截取指定长度的 <see cref="StringBuilder"/> 子字符串。
        /// </summary>
        /// <param name="this">要操作的 <see cref="StringBuilder"/> 实例。</param>
        /// <param name="startIndex">子字符串的起始索引。</param>
        /// <param name="length">要截取的长度。</param>
        /// <returns>指定范围的字符串。</returns>
        public static string Substring(this StringBuilder @this, int startIndex, int length)
        {
            return @this.ToString(startIndex, length);
        }
    }
}
