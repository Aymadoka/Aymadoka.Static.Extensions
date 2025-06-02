using Microsoft.Data.SqlClient;
using System.Data;

namespace Aymadoka.Static.DataExtension
{

    public static partial class DataExtensions
    {
        /// <summary>
        /// 为 <see cref="SqlCommand"/> 执行查询并返回结果集的 <see cref="DataTable"/>。
        /// </summary>
        /// <param name="this">要执行的 <see cref="SqlCommand"/> 实例。</param>
        /// <returns>包含查询结果的 <see cref="DataTable"/>。</returns>
        public static DataTable ExecuteDataTable(this SqlCommand @this)
        {
            var dt = new DataTable();
            using (var dataAdapter = new SqlDataAdapter(@this))
            {
                dataAdapter.Fill(dt);
            }

            return dt;
        }
    }
}