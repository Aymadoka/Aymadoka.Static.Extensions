using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// 判断指定对象是否为 <c>null</c>。
        /// </summary>
        /// <typeparam name="T">对象类型，必须为引用类型。</typeparam>
        /// <param name="source">要判断的对象。</param>
        /// <returns>如果对象为 <c>null</c>，返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsNull<T>([NotNullWhen(false)] this T? source) where T : class
        {
            return source == null;
        }
    }
}
