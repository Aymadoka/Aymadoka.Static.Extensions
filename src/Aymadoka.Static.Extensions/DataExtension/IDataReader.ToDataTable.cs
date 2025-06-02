using System.Data;

namespace Aymadoka.Static.DataExtension
{

    public static partial class DataExtensions
    {
        /// <summary>
        /// 将 <see cref="IDataReader"/> 的数据加载到 <see cref="DataTable"/> 中。
        /// </summary>
        /// <param name="this">要读取数据的 <see cref="IDataReader"/> 实例。</param>
        /// <returns>包含读取数据的 <see cref="DataTable"/> 实例。</returns>
        public static DataTable ToDataTable(this IDataReader @this)
        {
            var dt = new DataTable();
            dt.Load(@this);
            return dt;
        }
    }
}