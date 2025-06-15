namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        //  static bool IsNaN<T>(this T d) where T : struct, INumber<T>

        /// <summary>
        /// 判断指定的 <see cref="float"/> 值是否为 NaN（非数字）。
        /// </summary>
        /// <param name="this">要判断的 <see cref="float"/> 值。</param>
        /// <returns>如果值为 NaN，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsNaN(this float @this)
        {
            return float.IsNaN(@this);
        }

        /// <summary>
        /// 判断指定的 <see cref="double"/> 值是否为 NaN（非数字）。
        /// </summary>
        /// <param name="this">要判断的 <see cref="double"/> 值。</param>
        /// <returns>如果值为 NaN，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsNaN(this double @this)
        {
            return double.IsNaN(@this);
        }
    }
}
