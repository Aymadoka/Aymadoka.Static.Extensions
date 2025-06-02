using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 以指定类型获取指定索引的列值。
        /// </summary>
        /// <typeparam name="T">目标类型。</typeparam>
        /// <param name="this">数据读取器实例。</param>
        /// <param name="index">列的索引。</param>
        /// <returns>指定类型的列值。</returns>
        public static T GetValueAs<T>(this IDataReader @this, int index)
        {
            return (T)@this.GetValue(index);
        }

        /// <summary>
        /// 以指定类型获取指定列名的列值。
        /// </summary>
        /// <typeparam name="T">目标类型。</typeparam>
        /// <param name="this">数据读取器实例。</param>
        /// <param name="columnName">列名。</param>
        /// <returns>指定类型的列值。</returns>
        public static T GetValueAs<T>(this IDataReader @this, string columnName)
        {
            return (T)@this.GetValue(@this.GetOrdinal(columnName));
        }
    }
}