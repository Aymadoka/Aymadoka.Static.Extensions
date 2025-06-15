using System;

namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// 尝试通过指定的函数获取值，如果发生异常则返回类型的默认值。
        /// </summary>
        /// <typeparam name="T">源对象类型。</typeparam>
        /// <typeparam name="TResult">返回值类型。</typeparam>
        /// <param name="this">源对象。</param>
        /// <param name="func">用于获取值的函数。</param>
        /// <returns>获取到的值或类型的默认值。</returns>
        public static TResult GetValueOrDefault<T, TResult>(this T @this, Func<T, TResult> func)
        {
            try
            {
                return func(@this);
            }
            catch (Exception)
            {
                return default;
            }
        }

        /// <summary>
        /// 尝试通过指定的函数获取值，如果发生异常则返回指定的默认值。
        /// </summary>
        /// <typeparam name="T">源对象类型。</typeparam>
        /// <typeparam name="TResult">返回值类型。</typeparam>
        /// <param name="this">源对象。</param>
        /// <param name="func">用于获取值的函数。</param>
        /// <param name="defaultValue">异常时返回的默认值。</param>
        /// <returns>获取到的值或指定的默认值。</returns>
        public static TResult GetValueOrDefault<T, TResult>(this T @this, Func<T, TResult> func, TResult defaultValue)
        {
            try
            {
                return func(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// 尝试通过指定的函数获取值，如果发生异常则调用默认值工厂方法获取默认值。
        /// </summary>
        /// <typeparam name="T">源对象类型。</typeparam>
        /// <typeparam name="TResult">返回值类型。</typeparam>
        /// <param name="this">源对象。</param>
        /// <param name="func">用于获取值的函数。</param>
        /// <param name="defaultValueFactory">异常时用于生成默认值的工厂方法。</param>
        /// <returns>获取到的值或工厂方法生成的默认值。</returns>
        public static TResult GetValueOrDefault<T, TResult>(this T @this, Func<T, TResult> func, Func<TResult> defaultValueFactory)
        {
            try
            {
                return func(@this);
            }
            catch (Exception)
            {
                return defaultValueFactory();
            }
        }

        /// <summary>
        /// 尝试通过指定的函数获取值，如果发生异常则调用带源对象参数的默认值工厂方法获取默认值。
        /// </summary>
        /// <typeparam name="T">源对象类型。</typeparam>
        /// <typeparam name="TResult">返回值类型。</typeparam>
        /// <param name="this">源对象。</param>
        /// <param name="func">用于获取值的函数。</param>
        /// <param name="defaultValueFactory">异常时用于生成默认值的工厂方法，带源对象参数。</param>
        /// <returns>获取到的值或工厂方法生成的默认值。</returns>
        public static TResult GetValueOrDefault<T, TResult>(this T @this, Func<T, TResult> func, Func<T, TResult> defaultValueFactory)
        {
            try
            {
                return func(@this);
            }
            catch (Exception)
            {
                return defaultValueFactory(@this);
            }
        }
    }
}
