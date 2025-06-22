namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static bool IsNegativeInfinity<T>(this T d) where T : struct, INumber<T>

        /// <summary>
        /// 判断指定的 <see cref="float"/> 值是否为负无穷大。
        /// </summary>
        /// <param name="this">要判断的 <see cref="float"/> 值。</param>
        /// <returns>如果值为负无穷大，则为 <c>true</c>；否则为 <c>false</c>。</returns>
        public static bool IsNegativeInfinity(this float @this)
        {
            return float.IsNegativeInfinity(@this);
        }

        /// <summary>
        /// 判断指定的 <see cref="double"/> 值是否为负无穷大。
        /// </summary>
        /// <param name="this">要判断的 <see cref="double"/> 值。</param>
        /// <returns>如果值为负无穷大，则为 <c>true</c>；否则为 <c>false</c>。</returns>
        public static bool IsNegativeInfinity(this double @this)
        {
            return double.IsNegativeInfinity(@this);
        }
    }
}
