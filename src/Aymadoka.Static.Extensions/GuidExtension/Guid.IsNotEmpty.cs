using System;

namespace Aymadoka.Static.GuidExtension
{
    public static partial class GuidExtensions
    {
        /// <summary>
        /// 判断 Guid 是否不等于 Guid.Empty。
        /// </summary>
        /// <param name="this">要判断的 Guid 实例。</param>
        /// <returns>如果 Guid 不等于 Guid.Empty，则返回 true；否则返回 false。</returns>
        public static bool IsNotEmpty(this Guid @this)
        {
            return @this != Guid.Empty;
        }
    }
}
