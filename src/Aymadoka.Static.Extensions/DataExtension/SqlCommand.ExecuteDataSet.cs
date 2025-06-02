using Microsoft.Data.SqlClient;
using System.Data;

namespace Aymadoka.Static.DataExtension
{

    public static partial class DataExtensions
    {
        /// <summary>
        /// 为 <see cref="SqlCommand"/> 执行查询并返回 <see cref="DataSet"/>。
        /// </summary>
        /// <param name="this">要执行的 <see cref="SqlCommand"/> 实例。</param>
        /// <returns>包含查询结果的 <see cref="DataSet"/>。</returns>
        public static DataSet ExecuteDataSet(this SqlCommand @this)
        {
            var ds = new DataSet();
            using (var dataAdapter = new SqlDataAdapter(@this))
            {
                dataAdapter.Fill(ds);
            }

            return ds;
        }
    }
}