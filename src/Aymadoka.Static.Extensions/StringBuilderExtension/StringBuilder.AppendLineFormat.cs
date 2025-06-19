using System.Collections.Generic;
using System.Text;

namespace Aymadoka.Static.StringBuilderExtension
{
    public static partial class StringBuilderExtensions
    {
        /// <summary>
        /// 为 <see cref="StringBuilder"/> 添加格式化字符串并追加换行符。
        /// </summary>
        /// <param name="this">要追加内容的 <see cref="StringBuilder"/> 实例。</param>
        /// <param name="format">复合格式字符串。</param>
        /// <param name="args">格式化字符串的参数。</param>
        /// <returns>追加后的 <see cref="StringBuilder"/> 实例。</returns>
        public static StringBuilder AppendLineFormat(this StringBuilder @this, string format, params object[] args)
        {
            @this.AppendLine(string.Format(format, args));

            return @this;
        }
    }
}
