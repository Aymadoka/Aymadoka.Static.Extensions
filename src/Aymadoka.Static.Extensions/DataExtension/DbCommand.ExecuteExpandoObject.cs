using System.Data;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 执行 <see cref="DbCommand"/> 并返回首行数据作为动态对象（ExpandoObject）。
        /// </summary>
        /// <param name="this">要执行的 <see cref="DbCommand"/> 实例。</param>
        /// <returns>首行数据的动态对象表示；如果没有数据，则属性值为 null。</returns>
        public static dynamic ExecuteExpandoObject(this DbCommand @this)
        {
            using (IDataReader reader = @this.ExecuteReader())
            {
                reader.Read();
                return reader.ToExpandoObject();
            }
        }
    }
}