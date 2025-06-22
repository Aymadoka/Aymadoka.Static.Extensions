using Aymadoka.Static.NumberExtension;

namespace Aymadoka.Static.NullableNumberExtension
{
    public static partial class NullableNumberExtensions
    {
        /// <summary>
        /// 判断可空 <see cref="sbyte"/> 是否为零。
        /// </summary>
        /// <param name="source">可空 sbyte 值。</param>
        /// <returns>如果有值且为零返回 true，否则返回 false。</returns>
        public static bool IsZero(this sbyte? source)
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsZero();
        }

        /// <summary>
        /// 判断可空 <see cref="byte"/> 是否为零。
        /// </summary>
        /// <param name="source">可空 byte 值。</param>
        /// <returns>如果有值且为零返回 true，否则返回 false。</returns>
        public static bool IsZero(this byte? source)
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsZero();
        }

        /// <summary>
        /// 判断可空 <see cref="short"/> 是否为零。
        /// </summary>
        /// <param name="source">可空 short 值。</param>
        /// <returns>如果有值且为零返回 true，否则返回 false。</returns>
        public static bool IsZero(this short? source)
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsZero();
        }

        /// <summary>
        /// 判断可空 <see cref="ushort"/> 是否为零。
        /// </summary>
        /// <param name="source">可空 ushort 值。</param>
        /// <returns>如果有值且为零返回 true，否则返回 false。</returns>
        public static bool IsZero(this ushort? source)
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsZero();
        }

        /// <summary>
        /// 判断可空 <see cref="int"/> 是否为零。
        /// </summary>
        /// <param name="source">可空 int 值。</param>
        /// <returns>如果有值且为零返回 true，否则返回 false。</returns>
        public static bool IsZero(this int? source)
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsZero();
        }

        /// <summary>
        /// 判断可空 <see cref="uint"/> 是否为零。
        /// </summary>
        /// <param name="source">可空 uint 值。</param>
        /// <returns>如果有值且为零返回 true，否则返回 false。</returns>
        public static bool IsZero(this uint? source)
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsZero();
        }

        /// <summary>
        /// 判断可空 <see cref="long"/> 是否为零。
        /// </summary>
        /// <param name="source">可空 long 值。</param>
        /// <returns>如果有值且为零返回 true，否则返回 false。</returns>
        public static bool IsZero(this long? source)
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsZero();
        }

        /// <summary>
        /// 判断可空 <see cref="ulong"/> 是否为零。
        /// </summary>
        /// <param name="source">可空 ulong 值。</param>
        /// <returns>如果有值且为零返回 true，否则返回 false。</returns>
        public static bool IsZero(this ulong? source)
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsZero();
        }

        /// <summary>
        /// 判断可空 <see cref="float"/> 是否为零。
        /// </summary>
        /// <param name="source">可空 float 值。</param>
        /// <returns>如果有值且为零返回 true，否则返回 false。</returns>
        public static bool IsZero(this float? source)
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsZero();
        }

        /// <summary>
        /// 判断可空 <see cref="double"/> 是否为零。
        /// </summary>
        /// <param name="source">可空 double 值。</param>
        /// <returns>如果有值且为零返回 true，否则返回 false。</returns>
        public static bool IsZero(this double? source)
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsZero();
        }

        /// <summary>
        /// 判断可空 <see cref="decimal"/> 是否为零。
        /// </summary>
        /// <param name="source">可空 decimal 值。</param>
        /// <returns>如果有值且为零返回 true，否则返回 false。</returns>
        public static bool IsZero(this decimal? source)
        {
            if (!source.HasValue)
            {
                return false;
            }

            return source.Value.IsZero();
        }
    }
}
