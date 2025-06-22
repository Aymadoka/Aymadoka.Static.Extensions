using System;

namespace Aymadoka.Static.GuidExtension
{
    public static partial class GuidExtensions
    {
        /// <summary>
        /// 判断指定的 Guid 是否为 <see cref="Guid.Empty"/>。
        /// </summary>
        /// <param name="this">要判断的 Guid 实例。</param>
        /// <returns>如果 Guid 为空，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsEmpty(this Guid @this)
        {
            return @this == Guid.Empty;
        }
    }
}
