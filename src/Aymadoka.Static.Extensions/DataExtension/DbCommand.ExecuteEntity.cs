using System.Data;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 执行 <see cref="DbCommand"/> 并将结果的第一行映射为指定类型的实体。
        /// </summary>
        /// <typeparam name="T">要映射的实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">要执行的 <see cref="DbCommand"/> 实例。</param>
        /// <returns>映射后的实体对象。</returns>
        public static T ExecuteEntity<T>(this DbCommand @this) where T : new()
        {
            using (IDataReader reader = @this.ExecuteReader())
            {
                reader.Read();
                return reader.ToEntity<T>();
            }
        }
    }
}