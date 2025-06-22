using System;
using System.Text;

namespace Aymadoka.Static.StringBuilderExtension
{
    public static partial class StringBuilderExtensions
    {
        /// <summary>
        /// 根据指定的条件判断是否将值追加到 <see cref="StringBuilder"/> 实例中。
        /// </summary>
        /// <typeparam name="T">要追加的值的类型。</typeparam>
        /// <param name="this">要操作的 <see cref="StringBuilder"/> 实例。</param>
        /// <param name="predicate">用于判断是否追加的条件委托。</param>
        /// <param name="values">要判断并追加的值集合。</param>
        /// <returns>追加后的 <see cref="StringBuilder"/> 实例。</returns>
        public static StringBuilder AppendIf<T>(this StringBuilder @this, Func<T, bool> predicate, params T[] values)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            foreach (var value in values)
            {
                if (predicate(value))
                {
                    @this.Append(value);
                }
            }

            return @this;
        }
    }
}
