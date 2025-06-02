using Microsoft.Data.SqlClient;
using System;
using System.Reflection;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 通过反射获取 <see cref="SqlBulkCopy"/> 实例中关联的 <see cref="SqlTransaction"/>。
        /// </summary>
        /// <param name="this">要获取事务的 <see cref="SqlBulkCopy"/> 实例。</param>
        /// <returns>关联的 <see cref="SqlTransaction"/>，如果不存在则返回 null。</returns>
        public static SqlTransaction GetTransaction(this SqlBulkCopy @this)
        {
            Type type = @this.GetType();
            FieldInfo field = type.GetField("_externalTransaction", BindingFlags.NonPublic | BindingFlags.Instance);
            return field.GetValue(@this) as SqlTransaction;
        }
    }
}