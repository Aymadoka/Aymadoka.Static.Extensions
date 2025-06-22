using Aymadoka.Static.DateTimeExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        /// <summary>
        /// 计算指定可空 <see cref="DateTime"/> 的年龄（以年为单位）。
        /// </summary>
        /// <param name="this">要计算年龄的可空 <see cref="DateTime"/> 实例。</param>
        /// <returns>如果 <paramref name="this"/> 为 null，则返回 null；否则返回年龄（年）。</returns>
        public static int? Age(this DateTime? @this)
        {
            if (@this == null)
            {
                return null;
            }

            return @this.Value.Age();
        }
    }
}
