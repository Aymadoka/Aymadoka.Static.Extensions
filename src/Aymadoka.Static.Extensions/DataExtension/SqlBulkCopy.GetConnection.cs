using Microsoft.Data.SqlClient;
using System;
using System.Reflection;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 通过反射获取 <see cref="SqlBulkCopy"/> 实例的私有 SqlConnection 字段。
        /// </summary>
        /// <param name="this">扩展的 <see cref="SqlBulkCopy"/> 实例。</param>
        /// <returns>与 <see cref="SqlBulkCopy"/> 关联的 <see cref="SqlConnection"/> 实例。</returns>
        public static SqlConnection GetConnection(this SqlBulkCopy @this)
        {
            Type type = @this.GetType();
            FieldInfo field = type.GetField("_connection", BindingFlags.NonPublic | BindingFlags.Instance);
            return field.GetValue(@this) as SqlConnection;
        }
    }
}