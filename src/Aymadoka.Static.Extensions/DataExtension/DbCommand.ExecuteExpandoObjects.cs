using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 执行 <see cref="DbCommand"/> 并将结果集转换为动态对象集合（ExpandoObject）。
        /// </summary>
        /// <param name="this">要执行的 <see cref="DbCommand"/> 实例。</param>
        /// <returns>包含每一行数据的动态对象集合。</returns>
        public static IEnumerable<dynamic> ExecuteExpandoObjects(this DbCommand @this)
        {
            using (IDataReader reader = @this.ExecuteReader())
            {
                return reader.ToExpandoObjects();
            }
        }
    }
}