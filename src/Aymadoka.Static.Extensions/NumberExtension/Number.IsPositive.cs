using System.Numerics;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        /// <summary>判断小数值是否为正数</summary>
        /// <param name="source">需要判断的原始小数值</param>
        /// <returns>如果是正数返回 true，否则返回 false</returns>
        public static bool IsPositive<T>(this T source) where T : struct, INumber<T>
        {
            return source > T.One;
        }
    }
}
