using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aymadok.Static.Int32Extension
{
    public static class Int32Extensions
    {
        /// <summary>是否为零</summary>
        /// <param name="sourceInt32"></param>
        /// <returns></returns>
        public static bool IsZero(this int sourceInt32) => sourceInt32 == 0;

        /// <summary>是否为正整数</summary>
        /// <param name="sourceInt32"></param>
        /// <returns></returns>
        public static bool IsPositiveInteger(this int sourceInt32) => sourceInt32 > 0;

        public static bool IsNotPositiveInteger(this int sourceInt32) => !sourceInt32.IsPositiveInteger();

        /// <summary>是否为负整数</summary>
        /// <param name="sourceInt32"></param>
        /// <returns></returns>
        public static bool IsNegativeInteger(this int sourceInt32) => sourceInt32 < 0;

        public static bool IsNotNegativeInteger(this int sourceInt32) => !sourceInt32.IsNegativeInteger();


        /// <summary>最大公约数</summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static int GreatestCommonDivisor(this int number1, int number2)
        {
            if (number2 == 0)
            {
                return number1;
            }

            return number2.GreatestCommonDivisor(number1 % number2);
        }

        /// <summary>最小公倍数</summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static int LeastCommonMultiple(this int number1, int number2)
        {
            return number1 * number2 / number1.GreatestCommonDivisor(number2);
        }

        /// <summary>最小公倍数</summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <param name="number3"></param>
        /// <returns></returns>
        public static int LeastCommonMultiple(params int[] numbers)
        {
            if (numbers.Length == 1)
                return numbers[0];
            return numbers[0].LeastCommonMultiple(LeastCommonMultiple(numbers.Skip(1).ToArray()));
        }
    }
}
