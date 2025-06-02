using System.Data;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{

    /// <summary>
    /// 提供与数据库连接相关的扩展方法。
    /// </summary>
    public static partial class DataExtensions
    {
        /// <summary>
        /// 判断指定的 <see cref="DbConnection"/> 是否处于已打开状态。
        /// </summary>
        /// <param name="this">要检查状态的数据库连接实例。</param>
        /// <returns>如果连接已打开，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsConnectionOpen(this DbConnection @this)
        {
            return @this.State == ConnectionState.Open;
        }
    }
}