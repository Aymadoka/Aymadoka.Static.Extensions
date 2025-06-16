namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static bool Between<T>(this T @this, T minValue, T maxValue) where T : struct, INumber<T>

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="minValue"/> 和 <paramref name="maxValue"/> 之间（不包含边界）。
        /// </summary>
        public static bool Between(this sbyte @this, sbyte minValue, sbyte maxValue)
        {
            return @this > minValue && @this < maxValue;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="minValue"/> 和 <paramref name="maxValue"/> 之间（不包含边界）。
        /// </summary>
        public static bool Between(this byte @this, byte minValue, byte maxValue)
        {
            return @this > minValue && @this < maxValue;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="minValue"/> 和 <paramref name="maxValue"/> 之间（不包含边界）。
        /// </summary>
        public static bool Between(this short @this, short minValue, short maxValue)
        {
            return @this > minValue && @this < maxValue;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="minValue"/> 和 <paramref name="maxValue"/> 之间（不包含边界）。
        /// </summary>
        public static bool Between(this ushort @this, ushort minValue, ushort maxValue)
        {
            return @this > minValue && @this < maxValue;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="minValue"/> 和 <paramref name="maxValue"/> 之间（不包含边界）。
        /// </summary>
        public static bool Between(this int @this, int minValue, int maxValue)
        {
            return @this > minValue && @this < maxValue;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="minValue"/> 和 <paramref name="maxValue"/> 之间（不包含边界）。
        /// </summary>
        public static bool Between(this uint @this, uint minValue, uint maxValue)
        {
            return @this > minValue && @this < maxValue;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="minValue"/> 和 <paramref name="maxValue"/> 之间（不包含边界）。
        /// </summary>
        public static bool Between(this long @this, long minValue, long maxValue)
        {
            return @this > minValue && @this < maxValue;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="minValue"/> 和 <paramref name="maxValue"/> 之间（不包含边界）。
        /// </summary>
        public static bool Between(this ulong @this, ulong minValue, ulong maxValue)
        {
            return @this > minValue && @this < maxValue;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="minValue"/> 和 <paramref name="maxValue"/> 之间（不包含边界）。
        /// </summary>
        public static bool Between(this float @this, float minValue, float maxValue)
        {
            return @this > minValue && @this < maxValue;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="minValue"/> 和 <paramref name="maxValue"/> 之间（不包含边界）。
        /// </summary>
        public static bool Between(this double @this, double minValue, double maxValue)
        {
            return @this > minValue && @this < maxValue;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="minValue"/> 和 <paramref name="maxValue"/> 之间（不包含边界）。
        /// </summary>
        public static bool Between(this decimal @this, decimal minValue, decimal maxValue)
        {
            return @this > minValue && @this < maxValue;
        }
    }
}
