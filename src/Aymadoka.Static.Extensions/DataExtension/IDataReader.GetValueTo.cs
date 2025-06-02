using Aymadoka.Static.ObjectExtension;
using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 获取指定索引的值，并将其转换为指定类型 <typeparamref name="T"/>。
        /// </summary>
        /// <typeparam name="T">目标类型。</typeparam>
        /// <param name="this">数据读取器实例。</param>
        /// <param name="index">列的索引。</param>
        /// <returns>转换后的值。</returns>
        public static T GetValueTo<T>(this IDataReader @this, int index)
        {
            return @this.GetValue(index).To<T>();
        }

        /// <summary>
        /// 获取指定列名的值，并将其转换为指定类型 <typeparamref name="T"/>。
        /// </summary>
        /// <typeparam name="T">目标类型。</typeparam>
        /// <param name="this">数据读取器实例。</param>
        /// <param name="columnName">列名。</param>
        /// <returns>转换后的值。</returns>
        public static T GetValueTo<T>(this IDataReader @this, string columnName)
        {
            return @this.GetValue(@this.GetOrdinal(columnName)).To<T>();
        }
    }
}