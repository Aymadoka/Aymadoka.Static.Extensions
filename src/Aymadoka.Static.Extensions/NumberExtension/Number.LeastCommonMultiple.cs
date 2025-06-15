using System;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static T LeastCommonMultiple<T>(this T number1, T number2) where T : struct, INumber<T>

        // static T LeastCommonMultiple<T>(params T[] numbers) where T : struct, INumber<T>

        /// <summary>
        /// 计算两个 <see cref="int"/> 类型数值的最小公倍数。
        /// </summary>
        /// <param name="number1">第一个整数。</param>
        /// <param name="number2">第二个整数。</param>
        /// <returns>最小公倍数。</returns>
        public static int LeastCommonMultiple(this int number1, int number2)
        {
            return number1 * number2 / number1.GreatestCommonDivisor(number2);
        }

        /// <summary>
        /// 计算一组 <see cref="int"/> 类型数值的最小公倍数。
        /// </summary>
        /// <param name="numbers">整数数组。</param>
        /// <returns>最小公倍数。</returns>
        /// <exception cref="ArgumentException">当数组为空时抛出。</exception>
        public static int LeastCommonMultiple(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("The numbers array must contain at least one element.", nameof(numbers));
            }

            int lcm = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                lcm = lcm.LeastCommonMultiple(numbers[i]);
            }

            return lcm;
        }

        /// <summary>
        /// 计算两个 <see cref="uint"/> 类型数值的最小公倍数。
        /// </summary>
        /// <param name="number1">第一个无符号整数。</param>
        /// <param name="number2">第二个无符号整数。</param>
        /// <returns>最小公倍数。</returns>
        public static uint LeastCommonMultiple(this uint number1, uint number2)
        {
            return number1 * number2 / number1.GreatestCommonDivisor(number2);
        }

        /// <summary>
        /// 计算一组 <see cref="uint"/> 类型数值的最小公倍数。
        /// </summary>
        /// <param name="numbers">无符号整数数组。</param>
        /// <returns>最小公倍数。</returns>
        /// <exception cref="ArgumentException">当数组为空时抛出。</exception>
        public static uint LeastCommonMultiple(params uint[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("The numbers array must contain at least one element.", nameof(numbers));
            }

            uint lcm = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                lcm = lcm.LeastCommonMultiple(numbers[i]);
            }

            return lcm;
        }

        /// <summary>
        /// 计算两个 <see cref="long"/> 类型数值的最小公倍数。
        /// </summary>
        /// <param name="number1">第一个长整数。</param>
        /// <param name="number2">第二个长整数。</param>
        /// <returns>最小公倍数。</returns>
        public static long LeastCommonMultiple(this long number1, long number2)
        {
            return number1 * number2 / number1.GreatestCommonDivisor(number2);
        }

        /// <summary>
        /// 计算一组 <see cref="long"/> 类型数值的最小公倍数。
        /// </summary>
        /// <param name="numbers">长整数数组。</param>
        /// <returns>最小公倍数。</returns>
        /// <exception cref="ArgumentException">当数组为空时抛出。</exception>
        public static long LeastCommonMultiple(params long[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("The numbers array must contain at least one element.", nameof(numbers));
            }

            long lcm = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                lcm = lcm.LeastCommonMultiple(numbers[i]);
            }

            return lcm;
        }

        /// <summary>
        /// 计算两个 <see cref="ulong"/> 类型数值的最小公倍数。
        /// </summary>
        /// <param name="number1">第一个无符号长整数。</param>
        /// <param name="number2">第二个无符号长整数。</param>
        /// <returns>最小公倍数。</returns>
        public static ulong LeastCommonMultiple(this ulong number1, ulong number2)
        {
            return number1 * number2 / number1.GreatestCommonDivisor(number2);
        }

        /// <summary>
        /// 计算一组 <see cref="ulong"/> 类型数值的最小公倍数。
        /// </summary>
        /// <param name="numbers">无符号长整数数组。</param>
        /// <returns>最小公倍数。</returns>
        /// <exception cref="ArgumentException">当数组为空时抛出。</exception>
        public static ulong LeastCommonMultiple(params ulong[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("The numbers array must contain at least one element.", nameof(numbers));
            }

            ulong lcm = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                lcm = lcm.LeastCommonMultiple(numbers[i]);
            }

            return lcm;
        }
    }
}
