namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static T GreatestCommonDivisor<T>(this T number1, T number2) where T : struct, INumber<T>

        /// <summary>
        /// 计算两个 <see cref="int"/> 整数的最大公约数（GCD）。
        /// </summary>
        /// <param name="number1">第一个整数。</param>
        /// <param name="number2">第二个整数。</param>
        /// <returns>最大公约数。</returns>
        public static int GreatestCommonDivisor(this int number1, int number2)
        {
            if (number2.IsZero())
            {
                return number1;
            }

            var resp = number1 % number2;
            return number2.GreatestCommonDivisor(resp);
        }

        /// <summary>
        /// 计算两个 <see cref="uint"/> 无符号整数的最大公约数（GCD）。
        /// </summary>
        /// <param name="number1">第一个无符号整数。</param>
        /// <param name="number2">第二个无符号整数。</param>
        /// <returns>最大公约数。</returns>
        public static uint GreatestCommonDivisor(this uint number1, uint number2)
        {
            if (number2.IsZero())
            {
                return number1;
            }

            var resp = number1 % number2;
            return number2.GreatestCommonDivisor(resp);
        }

        /// <summary>
        /// 计算两个 <see cref="long"/> 长整型整数的最大公约数（GCD）。
        /// </summary>
        /// <param name="number1">第一个长整型整数。</param>
        /// <param name="number2">第二个长整型整数。</param>
        /// <returns>最大公约数。</returns>
        public static long GreatestCommonDivisor(this long number1, long number2)
        {
            if (number2.IsZero())
            {
                return number1;
            }

            var resp = number1 % number2;
            return number2.GreatestCommonDivisor(resp);
        }

        /// <summary>
        /// 计算两个 <see cref="ulong"/> 无符号长整型整数的最大公约数（GCD）。
        /// </summary>
        /// <param name="number1">第一个无符号长整型整数。</param>
        /// <param name="number2">第二个无符号长整型整数。</param>
        /// <returns>最大公约数。</returns>
        public static ulong GreatestCommonDivisor(this ulong number1, ulong number2)
        {
            if (number2.IsZero())
            {
                return number1;
            }

            var resp = number1 % number2;
            return number2.GreatestCommonDivisor(resp);
        }
    }
}
