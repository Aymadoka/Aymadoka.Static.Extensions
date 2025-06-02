using System;
using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 判断指定列名的值是否为 <see cref="DBNull"/>。
        /// </summary>
        /// <param name="this">要扩展的 <see cref="IDataReader"/> 实例。</param>
        /// <param name="name">列名。</param>
        /// <returns>如果该列的值为 <see cref="DBNull"/>，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsDBNull(this IDataReader @this, string name)
        {   
            return @this.IsDBNull(@this.GetOrdinal(name));
        }
    }
}