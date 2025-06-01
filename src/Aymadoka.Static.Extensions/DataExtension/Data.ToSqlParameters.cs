using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 将字典中的键值对转换为 <see cref="SqlParameter"/> 数组。
        /// </summary>
        /// <param name="this">包含参数名和参数值的字典。</param>
        /// <returns>转换后的 <see cref="SqlParameter"/> 数组。</returns>
        public static SqlParameter[] ToSqlParameters(this IDictionary<string, object> @this)
        {
            return @this.Select(x => new SqlParameter(x.Key, x.Value)).ToArray();
        }
    }
}
