using Aymadoka.Static.ObjectExtension;
using System;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 执行 <see cref="DbCommand.ExecuteScalar"/> 并将结果转换为指定类型 <typeparamref name="T"/>，如果发生异常则返回类型的默认值。
        /// </summary>
        /// <typeparam name="T">要转换的目标类型。</typeparam>
        /// <param name="this">要扩展的 <see cref="DbCommand"/> 实例。</param>
        /// <returns>转换后的结果或类型的默认值。</returns>
        public static T ExecuteScalarToOrDefault<T>(this DbCommand @this)
        {
            try
            {
                return @this.ExecuteScalar().To<T>();
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        /// <summary>
        /// 执行 <see cref="DbCommand.ExecuteScalar"/> 并将结果转换为指定类型 <typeparamref name="T"/>，如果发生异常则返回指定的默认值。
        /// </summary>
        /// <typeparam name="T">要转换的目标类型。</typeparam>
        /// <param name="this">要扩展的 <see cref="DbCommand"/> 实例。</param>
        /// <param name="defaultValue">异常时返回的默认值。</param>
        /// <returns>转换后的结果或指定的默认值。</returns>
        public static T ExecuteScalarToOrDefault<T>(this DbCommand @this, T defaultValue)
        {
            try
            {
                return @this.ExecuteScalar().To<T>();
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// 执行 <see cref="DbCommand.ExecuteScalar"/> 并将结果转换为指定类型 <typeparamref name="T"/>，如果发生异常则通过工厂方法获取默认值。
        /// </summary>
        /// <typeparam name="T">要转换的目标类型。</typeparam>
        /// <param name="this">要扩展的 <see cref="DbCommand"/> 实例。</param>
        /// <param name="defaultValueFactory">异常时用于生成默认值的工厂方法。</param>
        /// <returns>转换后的结果或工厂方法生成的默认值。</returns>
        public static T ExecuteScalarToOrDefault<T>(this DbCommand @this, Func<DbCommand, T> defaultValueFactory)
        {
            try
            {
                return @this.ExecuteScalar().To<T>();
            }
            catch (Exception)
            {
                return defaultValueFactory(@this);
            }
        }
    }
}