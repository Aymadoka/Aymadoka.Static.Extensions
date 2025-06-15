using System;
using System.Reflection;

namespace Aymadoka.Static.AssemblyExtension
{
    public static partial class AssemblyExtensions
    {
        /// <summary>
        /// 获取指定程序集上的第一个指定类型的特性。
        /// </summary>
        /// <typeparam name="T">要获取的特性类型，必须派生自 <see cref="Attribute"/>。</typeparam>
        /// <param name="this">要检查的程序集实例。</param>
        /// <returns>找到的第一个特性实例；如果未找到，则返回 <c>null</c>。</returns>
        public static T GetAttribute<T>(this Assembly @this) where T : Attribute
        {
            object[] configAttributes = Attribute.GetCustomAttributes(@this, typeof(T), false);

            if (configAttributes != null && configAttributes.Length > 0)
            {
                return (T)configAttributes[0];
            }

            return null;
        }
    }
}
