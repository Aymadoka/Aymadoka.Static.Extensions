using Aymadoka.Static.NumberExtension;
using System.Numerics;

namespace Aymadoka.Static.NullableNumberExtension
{
    public static partial class NullableNumberExtensions
    {
        /// <summary>判断小数值是否为正数</summary>
        /// <param name="source">需要判断的原始小数值</param>
        /// <returns>如果是正数返回 true，否则返回 false</returns>
        public static bool IsPositive<T>(this T? source) where T : struct, INumber<T>
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsPositive();
        }
    }
}
