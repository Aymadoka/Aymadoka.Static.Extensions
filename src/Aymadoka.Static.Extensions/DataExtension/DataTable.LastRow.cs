using System;
using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 获取 <see cref="DataTable"/> 的最后一行。
        /// </summary>
        /// <param name="this">要获取最后一行的 <see cref="DataTable"/> 实例。</param>
        /// <returns>最后一行的 <see cref="DataRow"/>。</returns>
        /// <exception cref="IndexOutOfRangeException">当表中没有行时抛出。</exception>
        public static DataRow LastRow(this DataTable @this)
        {
            return @this.Rows[@this.Rows.Count - 1];
        }
    }
}