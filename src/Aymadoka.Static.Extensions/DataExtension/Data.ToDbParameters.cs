using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 将字典中的键值对转换为 DbParameter 数组，使用指定的 DbCommand 创建参数。
        /// </summary>
        /// <param name="this">包含参数名和值的字典。</param>
        /// <param name="command">用于创建参数的 DbCommand 实例。</param>
        /// <returns>转换后的 DbParameter 数组。</returns>
        public static DbParameter[] ToDbParameters(this IDictionary<string, object> @this, DbCommand command)
        {
            return @this.Select(x =>
            {
                DbParameter parameter = command.CreateParameter();
                parameter.ParameterName = x.Key;
                parameter.Value = x.Value;
                return parameter;
            }).ToArray();
        }

        /// <summary>
        /// 将字典中的键值对转换为 DbParameter 数组，使用指定的 DbConnection 创建 DbCommand 并创建参数。
        /// </summary>
        /// <param name="this">包含参数名和值的字典。</param>
        /// <param name="connection">用于创建 DbCommand 的 DbConnection 实例。</param>
        /// <returns>转换后的 DbParameter 数组。</returns>
        public static DbParameter[] ToDbParameters(this IDictionary<string, object> @this, DbConnection connection)
        {
            DbCommand command = connection.CreateCommand();

            return @this.Select(x =>
            {
                DbParameter parameter = command.CreateParameter();
                parameter.ParameterName = x.Key;
                parameter.Value = x.Value;
                return parameter;
            }).ToArray();
        }
    }
}