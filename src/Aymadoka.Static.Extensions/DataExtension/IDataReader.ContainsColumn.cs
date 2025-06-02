using System;
using System.Data;

namespace Aymadoka.Static.DataExtension
{

    public static partial class DataExtensions
    {
        /// <summary>
        /// 判断指定的列索引在 <see cref="IDataReader"/> 中是否存在。
        /// </summary>
        /// <param name="this">要检查的 <see cref="IDataReader"/> 实例。</param>
        /// <param name="columnIndex">要检查的列索引。</param>
        /// <returns>如果列索引存在则返回 true，否则返回 false。</returns>
        public static bool ContainsColumn(this IDataReader @this, int columnIndex)
        {
            if (columnIndex < 0)
            {
                return false;
            }

            try
            {
                return columnIndex < @this.FieldCount;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断指定的列名在 <see cref="IDataReader"/> 中是否存在。
        /// </summary>
        /// <param name="this">要检查的 <see cref="IDataReader"/> 实例。</param>
        /// <param name="columnName">要检查的列名。</param>
        /// <returns>如果列名存在则返回 true，否则返回 false。</returns>
        public static bool ContainsColumn(this IDataReader @this, string columnName)
        {
            try
            {
                return @this.GetOrdinal(columnName) != -1;
            }
            catch (Exception)
            {
                try
                {
                    return @this[columnName] != null;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}