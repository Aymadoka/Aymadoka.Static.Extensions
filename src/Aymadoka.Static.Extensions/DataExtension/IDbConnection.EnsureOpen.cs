using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 确保数据库连接已打开。
        /// 如果连接当前为 <see cref="ConnectionState.Closed"/>，则调用 <see cref="IDbConnection.Open"/> 打开连接。
        /// </summary>
        /// <param name="this">要检查的数据库连接实例。</param>
        public static void EnsureOpen(this IDbConnection @this)
        {
            if (@this.State == ConnectionState.Closed)
            {
                @this.Open();
            }
        }
    }
}