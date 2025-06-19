using System.Collections.Generic;
using System.Text;

namespace Aymadoka.Static.StringBuilderExtension
{
    public static partial class StringBuilderExtensions
    {
        /// <summary>
        /// 为 <see cref="StringBuilder"/> 追加由分隔符连接的集合元素的字符串表示形式。
        /// </summary>
        /// <typeparam name="T">集合元素的类型。</typeparam>
        /// <param name="this">要追加内容的 <see cref="StringBuilder"/> 实例。</param>
        /// <param name="separator">用于分隔元素的字符串。</param>
        /// <param name="values">要连接的元素集合。</param>
        /// <returns>追加后的 <see cref="StringBuilder"/> 实例。</returns>
        public static StringBuilder AppendJoin<T>(this StringBuilder @this, string separator, IEnumerable<T> values)
        {
            @this.Append(string.Join(separator, values));

            return @this;
        }

        /// <summary>
        /// 为 <see cref="StringBuilder"/> 追加由分隔符连接的参数数组元素的字符串表示形式。
        /// </summary>
        /// <typeparam name="T">数组元素的类型。</typeparam>
        /// <param name="this">要追加内容的 <see cref="StringBuilder"/> 实例。</param>
        /// <param name="separator">用于分隔元素的字符串。</param>
        /// <param name="values">要连接的元素数组。</param>
        /// <returns>追加后的 <see cref="StringBuilder"/> 实例。</returns>
        public static StringBuilder AppendJoin<T>(this StringBuilder @this, string separator, params T[] values)
        {
            @this.Append(string.Join(separator, values));

            return @this;
        }
    }
}
