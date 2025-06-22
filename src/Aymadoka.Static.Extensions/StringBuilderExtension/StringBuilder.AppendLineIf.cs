using System;
using System.Text;

namespace Aymadoka.Static.StringBuilderExtension
{
    public static partial class StringBuilderExtensions
    {
        /// <summary>
        /// 根据指定的谓词条件，将满足条件的值逐行追加到 <see cref="StringBuilder"/> 实例中。
        /// </summary>
        /// <typeparam name="T">要追加的值的类型。</typeparam>
        /// <param name="this">要追加内容的 <see cref="StringBuilder"/> 实例。</param>
        /// <param name="predicate">用于判断值是否应被追加的谓词函数。</param>
        /// <param name="values">要判断并追加的值集合。</param>
        /// <returns>追加后的 <see cref="StringBuilder"/> 实例。</returns>
        public static StringBuilder AppendLineIf<T>(this StringBuilder @this, Func<T, bool> predicate, params T[] values)
        {
            foreach (var value in values)
            {
                if (predicate(value))
                {
                    @this.AppendLine(value?.ToString());
                }
            }

            return @this;
        }
    }
}
