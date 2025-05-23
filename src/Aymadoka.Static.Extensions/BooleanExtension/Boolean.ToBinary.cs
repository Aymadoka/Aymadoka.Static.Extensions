using System;

namespace Aymadoka.Static.BooleanExtension
{
    public static partial class BooleanExtensions
    {
        /// <summary>
        /// 将 <see cref="bool"/> 值转换为 <see cref="byte"/>，true 返回 1，false 返回 0
        /// </summary>
        /// <param name="this">要转换的布尔值</param>
        /// <returns>如果为 true，返回 1；否则返回 0</returns>
        public static byte ToByte(this bool @this)
        {
            return Convert.ToByte(@this);
        }
    }
}
