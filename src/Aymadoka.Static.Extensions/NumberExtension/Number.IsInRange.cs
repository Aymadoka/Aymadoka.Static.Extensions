using System.Numerics;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        /// <summary>判断小数值是否在指定范围内</summary>
        /// <param name="source">需要判断的原始小数值</param>
        /// <param name="min">范围的最小值</param>
        /// <param name="max">范围的最大值</param>
        /// <returns>如果在范围内返回 true，否则返回 false</returns>
        public static bool IsInRange<T>(this T source, T min, T max) where T : struct, INumber<T>
        {
            return source >= min && source <= max;
        }
    }
}
