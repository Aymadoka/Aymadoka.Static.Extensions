using System.Numerics;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        /// <summary>获取小数值的绝对值</summary>
        /// <param name="source">需要处理的原始小数值</param>
        /// <returns>小数值的绝对值</returns>
        public static T AbsoluteValue<T>(this T source) where T : struct, INumber<T>
        {
            return T.Abs(source);
        }
    }
}
