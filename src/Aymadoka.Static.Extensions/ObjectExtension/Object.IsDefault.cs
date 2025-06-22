using System.Collections.Generic;

namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// 判断指定对象是否为其类型的默认值。
        /// </summary>
        /// <typeparam name="T">对象的类型。</typeparam>
        /// <param name="this">要判断的对象。</param>
        /// <returns>如果对象为默认值，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsDefault<T>(this T @this)
        {
            var result = EqualityComparer<T>.Default.Equals(@this, default!);
            return result;
        }
    }
}
