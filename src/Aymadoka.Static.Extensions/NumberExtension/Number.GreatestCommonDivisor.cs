using System.Numerics;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        /// <summary>最大公约数</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static T GreatestCommonDivisor<T>(this T number1, T number2) where T : struct, INumber<T>
        {
            if (number2.IsZero())
            {
                return number1;
            }

            return number2.GreatestCommonDivisor(number1 % number2);
        }
    }
}
