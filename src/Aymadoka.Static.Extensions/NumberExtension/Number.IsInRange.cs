namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static bool IsInRange<T>(this T source, T min, T max) where T : struct, INumber<T>

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="min"/> 和 <paramref name="max"/> 之间（包含边界）。
        /// </summary>
        public static bool IsInRange(this sbyte @this, sbyte min, sbyte max)
        {
            return @this >= min && @this <= max;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="min"/> 和 <paramref name="max"/> 之间（包含边界）。
        /// </summary>
        public static bool IsInRange(this byte @this, byte min, byte max)
        {
            return @this >= min && @this <= max;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="min"/> 和 <paramref name="max"/> 之间（包含边界）。
        /// </summary>
        public static bool IsInRange(this short @this, short min, short max)
        {
            return @this >= min && @this <= max;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="min"/> 和 <paramref name="max"/> 之间（包含边界）。
        /// </summary>
        public static bool IsInRange(this ushort @this, ushort min, ushort max)
        {
            return @this >= min && @this <= max;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="min"/> 和 <paramref name="max"/> 之间（包含边界）。
        /// </summary>
        public static bool IsInRange(this int @this, int min, int max)
        {
            return @this >= min && @this <= max;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="min"/> 和 <paramref name="max"/> 之间（包含边界）。
        /// </summary>
        public static bool IsInRange(this uint @this, uint min, uint max)
        {
            return @this >= min && @this <= max;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="min"/> 和 <paramref name="max"/> 之间（包含边界）。
        /// </summary>
        public static bool IsInRange(this long @this, long min, long max)
        {
            return @this >= min && @this <= max;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="min"/> 和 <paramref name="max"/> 之间（包含边界）。
        /// </summary>
        public static bool IsInRange(this ulong @this, ulong min, ulong max)
        {
            return @this >= min && @this <= max;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="min"/> 和 <paramref name="max"/> 之间（包含边界）。
        /// </summary>
        public static bool IsInRange(this float @this, float min, float max)
        {
            return @this >= min && @this <= max;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="min"/> 和 <paramref name="max"/> 之间（包含边界）。
        /// </summary>
        public static bool IsInRange(this double @this, double min, double max)
        {
            return @this >= min && @this <= max;
        }

        /// <summary>
        /// 判断 <paramref name="this"/> 是否在 <paramref name="min"/> 和 <paramref name="max"/> 之间（包含边界）。
        /// </summary>
        public static bool IsInRange(this decimal @this, decimal min, decimal max)
        {
            return @this >= min && @this <= max;
        }
    }
}
