using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        /// <summary>
        /// 判断当前 <see cref="DateTime"/> 是否在指定的最小值和最大值之间（不包含边界）
        /// </summary>
        /// <param name="this">要判断的 <see cref="DateTime"/> 实例</param>
        /// <param name="minValue">区间的最小值（不包含）</param>
        /// <param name="maxValue">区间的最大值（不包含）</param>
        /// <returns>如果当前时间在区间内（不包含边界），返回 <c>true</c>；否则返回 <c>false</c></returns>
        public static bool Between(this DateTime @this, DateTime minValue, DateTime maxValue)
        {
            return minValue.CompareTo(@this) == -1 && @this.CompareTo(maxValue) == -1;
        }
    }
}
