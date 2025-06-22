using Aymadoka.Static.ObjectExtension;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 执行 <see cref="DbCommand.ExecuteScalar"/> 并将结果转换为指定类型 <typeparamref name="T"/>。
        /// </summary>
        /// <typeparam name="T">目标类型。</typeparam>
        /// <param name="this">要扩展的 <see cref="DbCommand"/> 实例。</param>
        /// <returns>转换后的结果。</returns>
        public static T ExecuteScalarTo<T>(this DbCommand @this)
        {
            return @this.ExecuteScalar().To<T>();
        }
    }
}