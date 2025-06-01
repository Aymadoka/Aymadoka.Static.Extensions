using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 执行 <see cref="DbCommand"/> 并将结果集转换为指定类型的实体集合。
        /// </summary>
        /// <typeparam name="T">实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">要执行的 <see cref="DbCommand"/> 实例。</param>
        /// <returns>类型为 <typeparamref name="T"/> 的实体集合。</returns>
        public static IEnumerable<T> ExecuteEntities<T>(this DbCommand @this) where T : new()
        {
            using (IDataReader reader = @this.ExecuteReader())
            {
                return reader.ToEntities<T>();
            }
        }
    }
}