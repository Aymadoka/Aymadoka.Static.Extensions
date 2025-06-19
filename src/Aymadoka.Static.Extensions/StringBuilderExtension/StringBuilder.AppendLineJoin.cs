using System.Collections.Generic;
using System.Text;

namespace Aymadoka.Static.StringBuilderExtension
{
    public static partial class StringBuilderExtensions
    {
        /// <summary>
        /// 为 <see cref="StringBuilder"/> 添加由分隔符连接的集合元素，并在末尾追加换行符。
        /// </summary>
        /// <typeparam name="T">集合元素的类型。</typeparam>
        /// <param name="this">要追加内容的 <see cref="StringBuilder"/> 实例。</param>
        /// <param name="separator">用于分隔元素的字符串。</param>
        /// <param name="values">要连接的元素集合。</param>
        /// <returns>追加后的 <see cref="StringBuilder"/> 实例。</returns>
        public static StringBuilder AppendLineJoin<T>(this StringBuilder @this, string separator, IEnumerable<T> values)
        {
            @this.AppendLine(string.Join(separator, values));

            return @this;
        }

        /// <summary>
        /// 为 <see cref="StringBuilder"/> 添加由分隔符连接的参数元素，并在末尾追加换行符。
        /// </summary>
        /// <param name="this">要追加内容的 <see cref="StringBuilder"/> 实例。</param>
        /// <param name="separator">用于分隔元素的字符串。</param>
        /// <param name="values">要连接的参数元素。</param>
        /// <returns>追加后的 <see cref="StringBuilder"/> 实例。</returns>
        public static StringBuilder AppendLineJoin(this StringBuilder @this, string separator, params object[] values)
        {
            @this.AppendLine(string.Join(separator, values));

            return @this;
        }
    }
}
