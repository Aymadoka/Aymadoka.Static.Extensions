using System;

namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// 为对象不为 null 时执行指定操作。
        /// </summary>
        /// <typeparam name="T">对象类型，必须为引用类型。</typeparam>
        /// <param name="this">要判断的对象。</param>
        /// <param name="action">对象不为 null 时要执行的操作。</param>
        public static void IfNotNull<T>(this T @this, Action<T> action) where T : class
        {
            if (@this != null)
            {
                action(@this);
            }
        }

        /// <summary>
        /// 为对象不为 null 时执行指定函数并返回结果，否则返回默认值。
        /// </summary>
        /// <typeparam name="T">对象类型，必须为引用类型。</typeparam>
        /// <typeparam name="TResult">返回值类型。</typeparam>
        /// <param name="this">要判断的对象。</param>
        /// <param name="func">对象不为 null 时要执行的函数。</param>
        /// <returns>函数返回值或默认值。</returns>
        public static TResult IfNotNull<T, TResult>(this T @this, Func<T, TResult> func) where T : class
        {
            if (@this != null)
            {
                return func(@this);
            }

            return default;
        }

        /// <summary>
        /// 为对象不为 null 时执行指定函数并返回结果，否则返回指定的默认值。
        /// </summary>
        /// <typeparam name="T">对象类型，必须为引用类型。</typeparam>
        /// <typeparam name="TResult">返回值类型。</typeparam>
        /// <param name="this">要判断的对象。</param>
        /// <param name="func">对象不为 null 时要执行的函数。</param>
        /// <param name="defaultValue">对象为 null 时返回的默认值。</param>
        /// <returns>函数返回值或指定的默认值。</returns>
        public static TResult IfNotNull<T, TResult>(this T @this, Func<T, TResult> func, TResult defaultValue) where T : class
        {
            if (@this != null)
            {
                return func(@this);
            }

            return defaultValue;
        }

        /// <summary>
        /// 为对象不为 null 时执行指定函数并返回结果，否则通过工厂方法获取默认值。
        /// </summary>
        /// <typeparam name="T">对象类型，必须为引用类型。</typeparam>
        /// <typeparam name="TResult">返回值类型。</typeparam>
        /// <param name="this">要判断的对象。</param>
        /// <param name="func">对象不为 null 时要执行的函数。</param>
        /// <param name="defaultValueFactory">对象为 null 时用于生成默认值的工厂方法。</param>
        /// <returns>函数返回值或工厂方法生成的默认值。</returns>
        public static TResult IfNotNull<T, TResult>(this T @this, Func<T, TResult> func, Func<TResult> defaultValueFactory) where T : class
        {
            if (@this != null)
            {
                return func(@this);
            }

            return defaultValueFactory();
        }
    }
}
