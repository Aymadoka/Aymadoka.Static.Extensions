namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static bool InRange<T>(this T @this, T minValue, T maxValue) where T : struct, INumber<T>

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="minValue"/> 和 <paramref name="maxValue"/> 之间（包含边界）。
        /// </summary>
        public static bool InRange(this sbyte @this, sbyte minValue, sbyte maxValue)
        {
            return @this.CompareTo(minValue) >= 0 && @this.CompareTo(maxValue) <= 0;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="minValue"/> 和 <paramref name="maxValue"/> 之间（包含边界）。
        /// </summary>
        public static bool InRange(this byte @this, byte minValue, byte maxValue)
        {
            return @this.CompareTo(minValue) >= 0 && @this.CompareTo(maxValue) <= 0;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="minValue"/> 和 <paramref name="maxValue"/> 之间（包含边界）。
        /// </summary>
        public static bool InRange(this short @this, short minValue, short maxValue)
        {
            return @this.CompareTo(minValue) >= 0 && @this.CompareTo(maxValue) <= 0;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="minValue"/> 和 <paramref name="maxValue"/> 之间（包含边界）。
        /// </summary>
        public static bool InRange(this ushort @this, ushort minValue, ushort maxValue)
        {
            return @this.CompareTo(minValue) >= 0 && @this.CompareTo(maxValue) <= 0;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="minValue"/> 和 <paramref name="maxValue"/> 之间（包含边界）。
        /// </summary>
        public static bool InRange(this int @this, int minValue, int maxValue)
        {
            return @this.CompareTo(minValue) >= 0 && @this.CompareTo(maxValue) <= 0;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="minValue"/> 和 <paramref name="maxValue"/> 之间（包含边界）。
        /// </summary>
        public static bool InRange(this uint @this, uint minValue, uint maxValue)
        {
            return @this.CompareTo(minValue) >= 0 && @this.CompareTo(maxValue) <= 0;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="minValue"/> 和 <paramref name="maxValue"/> 之间（包含边界）。
        /// </summary>
        public static bool InRange(this long @this, long minValue, long maxValue)
        {
            return @this.CompareTo(minValue) >= 0 && @this.CompareTo(maxValue) <= 0;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="minValue"/> 和 <paramref name="maxValue"/> 之间（包含边界）。
        /// </summary>
        public static bool InRange(this ulong @this, ulong minValue, ulong maxValue)
        {
            return @this.CompareTo(minValue) >= 0 && @this.CompareTo(maxValue) <= 0;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="minValue"/> 和 <paramref name="maxValue"/> 之间（包含边界）。
        /// </summary>
        public static bool InRange(this float @this, float minValue, float maxValue)
        {
            return @this.CompareTo(minValue) >= 0 && @this.CompareTo(maxValue) <= 0;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="minValue"/> 和 <paramref name="maxValue"/> 之间（包含边界）。
        /// </summary>
        public static bool InRange(this double @this, double minValue, double maxValue)
        {
            return @this.CompareTo(minValue) >= 0 && @this.CompareTo(maxValue) <= 0;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="minValue"/> 和 <paramref name="maxValue"/> 之间（包含边界）。
        /// </summary>
        public static bool InRange(this decimal @this, decimal minValue, decimal maxValue)
        {
            return @this.CompareTo(minValue) >= 0 && @this.CompareTo(maxValue) <= 0;
        }
    }
}
