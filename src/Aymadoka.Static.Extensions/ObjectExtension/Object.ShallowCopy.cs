using System;
using System.Reflection;

namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// 对指定对象进行浅拷贝。
        /// </summary>
        /// <typeparam name="T">对象类型，必须为引用类型。</typeparam>
        /// <param name="this">要进行浅拷贝的对象实例。</param>
        /// <returns>浅拷贝后的新对象；如果原对象为 null，则返回 null。</returns>
        /// <exception cref="InvalidOperationException">如果类型不支持浅拷贝时抛出。</exception>
        public static T? ShallowCopy<T>(this T? @this) where T : class
        {
            if (@this == null)
            {
                return null;
            }
#pragma warning disable S3011
            var bindingAttr = BindingFlags.NonPublic | BindingFlags.Instance;
#pragma warning restore S3011

            // 使用反射调用 MemberwiseClone
            var method = @this.GetType().GetMethod("MemberwiseClone", bindingAttr);

            var response = method.Invoke(@this, null);
            var result = response!.As<T>();
            return result;
        }
    }
}
