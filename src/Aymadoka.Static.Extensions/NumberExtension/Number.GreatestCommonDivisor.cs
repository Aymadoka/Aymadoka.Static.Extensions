namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static T GreatestCommonDivisor<T>(this T number1, T number2) where T : struct, INumber<T>

        public static int GreatestCommonDivisor(this int number1, int number2)
        {
            if (number2.IsZero())
            {
                return number1;
            }

            var resp = number1 % number2;
            return number2.GreatestCommonDivisor(resp);
        }

        public static uint GreatestCommonDivisor(this uint number1, uint number2)
        {
            if (number2.IsZero())
            {
                return number1;
            }

            var resp = number1 % number2;
            return number2.GreatestCommonDivisor(resp);
        }

        public static long GreatestCommonDivisor(this long number1, long number2)
        {
            if (number2.IsZero())
            {
                return number1;
            }

            var resp = number1 % number2;
            return number2.GreatestCommonDivisor(resp);
        }

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
