using System;
using System.Numerics;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static T LeastCommonMultiple<T>(this T number1, T number2) where T : struct, INumber<T>

        // static T LeastCommonMultiple<T>(params T[] numbers) where T : struct, INumber<T>

        public static int LeastCommonMultiple(this int number1, int number2)
        {
            return number1 * number2 / number1.GreatestCommonDivisor(number2);
        }

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

        public static uint LeastCommonMultiple(this uint number1, uint number2)
        {
            return number1 * number2 / number1.GreatestCommonDivisor(number2);
        }

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

        public static long LeastCommonMultiple(this long number1, long number2)
        {
            return number1 * number2 / number1.GreatestCommonDivisor(number2);
        }

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

        public static ulong LeastCommonMultiple(this ulong number1, ulong number2)
        {
            return number1 * number2 / number1.GreatestCommonDivisor(number2);
        }

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
