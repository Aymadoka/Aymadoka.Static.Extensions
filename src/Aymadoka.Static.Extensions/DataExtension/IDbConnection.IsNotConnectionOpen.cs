using System.Data;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 判断指定的 <see cref="DbConnection"/> 是否未处于打开状态。
        /// </summary>
        /// <param name="this">要检查状态的数据库连接实例。</param>
        /// <returns>如果连接未处于 <see cref="ConnectionState.Open"/> 状态，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsNotConnectionOpen(this DbConnection @this)
        {
            return @this.State != ConnectionState.Open;
        }
    }
}