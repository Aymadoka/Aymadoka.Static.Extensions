using System;

namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// 尝试将对象转换为指定类型，若失败则返回类型的默认值。
        /// </summary>
        /// <typeparam name="T">目标类型。</typeparam>
        /// <param name="this">要转换的对象。</param>
        /// <returns>转换成功则返回目标类型的值，否则返回默认值。</returns>
        public static T AsOrDefault<T>(this object? @this)
        {
            if (@this is T value)
            {
                return value;
            }

            return default(T);
        }

        /// <summary>
        /// 尝试将对象转换为指定类型，若失败则返回指定的默认值。
        /// </summary>
        /// <typeparam name="T">目标类型。</typeparam>
        /// <param name="this">要转换的对象。</param>
        /// <param name="defaultValue">转换失败时返回的默认值。</param>
        /// <returns>转换成功则返回目标类型的值，否则返回指定的默认值。</returns>
        public static T AsOrDefault<T>(this object? @this, T defaultValue)
        {
            if (@this is T value)
            {
                return value;
            }

            return defaultValue;
        }

        /// <summary>
        /// 尝试将对象转换为指定类型，若失败则通过工厂方法获取默认值。
        /// </summary>
        /// <typeparam name="T">目标类型。</typeparam>
        /// <param name="this">要转换的对象。</param>
        /// <param name="defaultValueFactory">转换失败时用于生成默认值的工厂方法。</param>
        /// <returns>转换成功则返回目标类型的值，否则返回工厂方法生成的默认值。</returns>
        public static T AsOrDefault<T>(this object? @this, Func<T> defaultValueFactory)
        {
            if (@this is T value)
            {
                return value;
            }

            return defaultValueFactory();
        }

        /// <summary>
        /// 尝试将对象转换为指定类型，若失败则通过工厂方法（带原对象参数）获取默认值。
        /// </summary>
        /// <typeparam name="T">目标类型。</typeparam>
        /// <param name="this">要转换的对象。</param>
        /// <param name="defaultValueFactory">转换失败时用于生成默认值的工厂方法，参数为原对象。</param>
        /// <returns>转换成功则返回目标类型的值，否则返回工厂方法生成的默认值。</returns>
        public static T AsOrDefault<T>(this object @this, Func<object, T> defaultValueFactory)
        {
            if (@this is T value)
            {
                return value;
            }

            return defaultValueFactory(@this);
        }
    }
}
