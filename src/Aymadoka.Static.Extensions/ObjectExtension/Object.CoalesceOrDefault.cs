using System;

namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// 返回当前对象，如果为 null，则返回参数列表中第一个非 null 的值，否则返回默认值。
        /// </summary>
        /// <typeparam name="T">引用类型。</typeparam>
        /// <param name="this">当前对象。</param>
        /// <param name="values">备用值列表。</param>
        /// <returns>第一个非 null 的值或默认值。</returns>
        public static T? CoalesceOrDefault<T>(this T? @this, params T[] values) where T : class
        {
            if (@this != null)
            {
                return @this;
            }

            foreach (T value in values)
            {
                if (value != null)
                {
                    return value;
                }
            }

            return default;
        }

        /// <summary>
        /// 返回当前对象，如果为 null，则返回参数列表中第一个非 null 的值，否则通过工厂方法获取默认值。
        /// </summary>
        /// <typeparam name="T">引用类型。</typeparam>
        /// <param name="this">当前对象。</param>
        /// <param name="defaultValueFactory">默认值工厂方法。</param>
        /// <param name="values">备用值列表。</param>
        /// <returns>第一个非 null 的值或工厂方法生成的默认值。</returns>
        public static T? CoalesceOrDefault<T>(this T? @this, Func<T?> defaultValueFactory, params T[] values) where T : class
        {
            if (@this != null)
            {
                return @this;
            }

            foreach (T value in values)
            {
                if (value != null)
                {
                    return value;
                }
            }

            return defaultValueFactory();
        }

        /// <summary>
        /// 返回当前对象，如果为 null，则返回参数列表中第一个非 null 的值，否则通过工厂方法获取默认值（可传入当前对象）。
        /// </summary>
        /// <typeparam name="T">引用类型。</typeparam>
        /// <param name="this">当前对象。</param>
        /// <param name="defaultValueFactory">默认值工厂方法，接收当前对象作为参数。</param>
        /// <param name="values">备用值列表。</param>
        /// <returns>第一个非 null 的值或工厂方法生成的默认值。</returns>
        public static T? CoalesceOrDefault<T>(this T? @this, Func<T?, T?> defaultValueFactory, params T[] values) where T : class
        {
            if (@this != null)
            {
                return @this;
            }

            foreach (T value in values)
            {
                if (value != null)
                {
                    return value;
                }
            }

            return defaultValueFactory(@this);
        }
    }
}
