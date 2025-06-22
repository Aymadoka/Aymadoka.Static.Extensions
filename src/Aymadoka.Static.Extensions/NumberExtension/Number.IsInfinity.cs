namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        // static bool IsInfinity<T>(this T d) where T : struct, INumber<T>

        /// <summary>
        /// 判断指定的 <see cref="float"/> 值是否为正无穷大或负无穷大。
        /// </summary>
        /// <param name="this">要检查的浮点数。</param>
        /// <returns>如果值为正无穷大或负无穷大，则为 <c>true</c>；否则为 <c>false</c>。</returns>
        public static bool IsInfinity(this float @this)
        {
            return float.IsInfinity(@this);
        }

        /// <summary>
        /// 判断指定的 <see cref="double"/> 值是否为正无穷大或负无穷大。
        /// </summary>
        /// <param name="this">要检查的双精度浮点数。</param>
        /// <returns>如果值为正无穷大或负无穷大，则为 <c>true</c>；否则为 <c>false</c>。</returns>
        public static bool IsInfinity(this double @this)
        {
            return double.IsInfinity(@this);
        }
    }
}
