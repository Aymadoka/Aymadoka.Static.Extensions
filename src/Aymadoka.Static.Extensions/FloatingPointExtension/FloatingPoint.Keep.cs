using System;
using System.Numerics;

namespace Aymadoka.Static.FloatingPointExtension
{
    public static partial class NumberExtensions
    {
        /// <summary>使用四舍五入的方式保留指定的小数位</summary>
        /// <param name="source">需要处理的原始小数值</param>
        /// <param name="keepPlaceCount">需要保留的小数位数</param>
        /// <returns>保留指定小数位后的结果</returns>
        public static T Keep<T>(this T source, int keepPlaceCount = 2) where T : struct, IFloatingPoint<T>
        {
            return T.Round(source, keepPlaceCount, MidpointRounding.AwayFromZero);
        }
    }
}
