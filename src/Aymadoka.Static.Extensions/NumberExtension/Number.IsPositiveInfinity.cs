namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static bool IsPositiveInfinity<T>(this T d) where T : struct, INumber<T>

        /// <summary>
        /// 判断指定的 <see cref="float"/> 值是否为正无穷大。
        /// </summary>
        /// <param name="this">要判断的 <see cref="float"/> 值。</param>
        /// <returns>如果值为正无穷大，则为 <c>true</c>；否则为 <c>false</c>。</returns>
        public static bool IsPositiveInfinity(this float @this)
        {
            return float.IsPositiveInfinity(@this);
        }

        /// <summary>
        /// 判断指定的 <see cref="double"/> 值是否为正无穷大。
        /// </summary>
        /// <param name="this">要判断的 <see cref="double"/> 值。</param>
        /// <returns>如果值为正无穷大，则为 <c>true</c>；否则为 <c>false</c>。</returns>
        public static bool IsPositiveInfinity(this double @this)
        {
            return double.IsPositiveInfinity(@this);
        }
    }
}
