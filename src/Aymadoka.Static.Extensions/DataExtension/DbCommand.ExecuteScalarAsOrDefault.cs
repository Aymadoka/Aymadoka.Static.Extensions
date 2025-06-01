using System;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 执行 <see cref="DbCommand.ExecuteScalar"/> 并将结果转换为指定类型，如果发生异常则返回类型的默认值。
        /// </summary>
        /// <typeparam name="T">要转换的目标类型。</typeparam>
        /// <param name="this">要扩展的 <see cref="DbCommand"/> 实例。</param>
        /// <returns>转换后的结果，或类型的默认值。</returns>
        public static T ExecuteScalarAsOrDefault<T>(this DbCommand @this)
        {
            try
            {
                return (T)@this.ExecuteScalar();
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        /// <summary>
        /// 执行 <see cref="DbCommand.ExecuteScalar"/> 并将结果转换为指定类型，如果发生异常则返回指定的默认值。
        /// </summary>
        /// <typeparam name="T">要转换的目标类型。</typeparam>
        /// <param name="this">要扩展的 <see cref="DbCommand"/> 实例。</param>
        /// <param name="defaultValue">发生异常时返回的默认值。</param>
        /// <returns>转换后的结果，或指定的默认值。</returns>
        public static T ExecuteScalarAsOrDefault<T>(this DbCommand @this, T defaultValue)
        {
            try
            {
                return (T)@this.ExecuteScalar();
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// 执行 <see cref="DbCommand.ExecuteScalar"/> 并将结果转换为指定类型，如果发生异常则调用指定的默认值工厂方法。
        /// </summary>
        /// <typeparam name="T">要转换的目标类型。</typeparam>
        /// <param name="this">要扩展的 <see cref="DbCommand"/> 实例。</param>
        /// <param name="defaultValueFactory">发生异常时用于生成默认值的工厂方法。</param>
        /// <returns>转换后的结果，或工厂方法生成的默认值。</returns>
        public static T ExecuteScalarAsOrDefault<T>(this DbCommand @this, Func<DbCommand, T> defaultValueFactory)
        {
            try
            {
                return (T)@this.ExecuteScalar();
            }
            catch (Exception)
            {
                return defaultValueFactory(@this);
            }
        }
    }
}