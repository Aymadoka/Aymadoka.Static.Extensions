using System;
using System.Globalization;
using System.Reflection;

namespace Aymadoka.Static.TyepExtension
{
    public static partial class TyepExtensions
    {
        /// <summary>
        /// 使用指定的绑定特性、绑定器、参数和区域性信息创建指定类型的实例，并强制转换为 T。
        /// </summary>
        /// <typeparam name="T">要创建的对象类型。</typeparam>
        /// <param name="this">要创建实例的类型。</param>
        /// <param name="bindingAttr">控制搜索类型成员的绑定标志。</param>
        /// <param name="binder">用于绑定的对象。</param>
        /// <param name="args">构造函数参数。</param>
        /// <param name="culture">区域性信息。</param>
        /// <returns>类型为 T 的新实例。</returns>
        public static T CreateInstance<T>(this Type @this, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture)
        {
            var result = (T)Activator.CreateInstance(@this, bindingAttr, binder, args, culture);
            return result;
        }

        /// <summary>
        /// 使用指定的绑定特性、绑定器、参数、区域性信息和激活属性创建指定类型的实例，并强制转换为 T。
        /// </summary>
        /// <typeparam name="T">要创建的对象类型。</typeparam>
        /// <param name="this">要创建实例的类型。</param>
        /// <param name="bindingAttr">控制搜索类型成员的绑定标志。</param>
        /// <param name="binder">用于绑定的对象。</param>
        /// <param name="args">构造函数参数。</param>
        /// <param name="culture">区域性信息。</param>
        /// <param name="activationAttributes">激活属性。</param>
        /// <returns>类型为 T 的新实例。</returns>
        public static T CreateInstance<T>(this Type @this, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
        {
            var result = (T)Activator.CreateInstance(@this, bindingAttr, binder, args, culture, activationAttributes);
            return result;
        }

        /// <summary>
        /// 使用指定参数创建指定类型的实例，并强制转换为 T。
        /// </summary>
        /// <typeparam name="T">要创建的对象类型。</typeparam>
        /// <param name="this">要创建实例的类型。</param>
        /// <param name="args">构造函数参数。</param>
        /// <returns>类型为 T 的新实例。</returns>
        public static T CreateInstance<T>(this Type @this, object[] args)
        {
            var result = (T)Activator.CreateInstance(@this, args);
            return result;
        }

        /// <summary>
        /// 使用指定参数和激活属性创建指定类型的实例，并强制转换为 T。
        /// </summary>
        /// <typeparam name="T">要创建的对象类型。</typeparam>
        /// <param name="this">要创建实例的类型。</param>
        /// <param name="args">构造函数参数。</param>
        /// <param name="activationAttributes">激活属性。</param>
        /// <returns>类型为 T 的新实例。</returns>
        public static T CreateInstance<T>(this Type @this, object[] args, object[] activationAttributes)
        {
            var result = (T)Activator.CreateInstance(@this, args, activationAttributes);
            return result;
        }

        /// <summary>
        /// 创建指定类型的实例，并强制转换为 T。
        /// </summary>
        /// <typeparam name="T">要创建的对象类型。</typeparam>
        /// <param name="this">要创建实例的类型。</param>
        /// <returns>类型为 T 的新实例。</returns>
        public static T CreateInstance<T>(this Type @this)
        {
            var result = (T)Activator.CreateInstance(@this);
            return result;
        }

        /// <summary>
        /// 创建指定类型的实例，并强制转换为 T。可指定是否允许非公共构造函数。
        /// </summary>
        /// <typeparam name="T">要创建的对象类型。</typeparam>
        /// <param name="this">要创建实例的类型。</param>
        /// <param name="nonPublic">是否允许非公共构造函数。</param>
        /// <returns>类型为 T 的新实例。</returns>
        public static T CreateInstance<T>(this Type @this, Boolean nonPublic)
        {
            var result = (T)Activator.CreateInstance(@this, nonPublic);
            return result;
        }

        /// <summary>
        /// 使用指定的绑定特性、绑定器、参数和区域性信息创建指定类型的实例。
        /// </summary>
        /// <param name="type">要创建实例的类型。</param>
        /// <param name="bindingAttr">控制搜索类型成员的绑定标志。</param>
        /// <param name="binder">用于绑定的对象。</param>
        /// <param name="args">构造函数参数。</param>
        /// <param name="culture">区域性信息。</param>
        /// <returns>新创建的对象实例。</returns>
        public static object? CreateInstance(this Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture)
        {
            var result = Activator.CreateInstance(type, bindingAttr, binder, args, culture);
            return result;
        }

        /// <summary>
        /// 使用指定的绑定特性、绑定器、参数、区域性信息和激活属性创建指定类型的实例。
        /// </summary>
        /// <param name="type">要创建实例的类型。</param>
        /// <param name="bindingAttr">控制搜索类型成员的绑定标志。</param>
        /// <param name="binder">用于绑定的对象。</param>
        /// <param name="args">构造函数参数。</param>
        /// <param name="culture">区域性信息。</param>
        /// <param name="activationAttributes">激活属性。</param>
        /// <returns>新创建的对象实例。</returns>
        public static object? CreateInstance(this Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
        {
            var result = Activator.CreateInstance(type, bindingAttr, binder, args, culture, activationAttributes);
            return result;
        }

        /// <summary>
        /// 使用指定参数创建指定类型的实例。
        /// </summary>
        /// <param name="type">要创建实例的类型。</param>
        /// <param name="args">构造函数参数。</param>
        /// <returns>新创建的对象实例。</returns>
        public static object? CreateInstance(this Type type, object[] args)
        {
            var result = Activator.CreateInstance(type, args);
            return result;
        }

        /// <summary>
        /// 使用指定参数和激活属性创建指定类型的实例。
        /// </summary>
        /// <param name="type">要创建实例的类型。</param>
        /// <param name="args">构造函数参数。</param>
        /// <param name="activationAttributes">激活属性。</param>
        /// <returns>新创建的对象实例。</returns>
        public static object? CreateInstance(this Type type, object[] args, object[] activationAttributes)
        {
            var result = Activator.CreateInstance(type, args, activationAttributes);
            return result;
        }

        /// <summary>
        /// 创建指定类型的实例。
        /// </summary>
        /// <param name="type">要创建实例的类型。</param>
        /// <returns>新创建的对象实例。</returns>
        public static object? CreateInstance(this Type type)
        {
            var result = Activator.CreateInstance(type);
            return result;
        }

        /// <summary>
        /// 创建指定类型的实例。可指定是否允许非公共构造函数。
        /// </summary>
        /// <param name="type">要创建实例的类型。</param>
        /// <param name="nonPublic">是否允许非公共构造函数。</param>
        /// <returns>新创建的对象实例。</returns>
        public static object? CreateInstance(this Type type, bool nonPublic)
        {
            var result = Activator.CreateInstance(type, nonPublic);
            return result;
        }
    }
}
