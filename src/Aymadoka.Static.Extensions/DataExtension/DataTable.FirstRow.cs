using System;
using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 获取 <see cref="DataTable"/> 的第一行。
        /// </summary>
        /// <param name="this">要获取第一行的 <see cref="DataTable"/> 实例。</param>
        /// <returns>第一行 <see cref="DataRow"/>。</returns>
        /// <exception cref="IndexOutOfRangeException">如果表中没有行，则抛出异常。</exception>
        public static DataRow FirstRow(this DataTable @this)
        {
            return @this.Rows[0];
        }
    }
}