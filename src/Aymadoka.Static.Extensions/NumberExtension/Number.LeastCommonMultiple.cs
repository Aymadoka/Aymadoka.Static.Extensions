using System;
using System.Numerics;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        /// <summary>最小公倍数</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static T LeastCommonMultiple<T>(this T number1, T number2) where T : struct, INumber<T>
        {
            return number1 * number2 / number1.GreatestCommonDivisor(number2);
        }

        /// <summary>最小公倍数</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static T LeastCommonMultiple<T>(params T[] numbers) where T : struct, INumber<T>
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("The numbers array must contain at least one element.", nameof(numbers));
            }

            T lcm = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                lcm = lcm.LeastCommonMultiple(numbers[i]);
            }

            return lcm;
        }
    }
}
