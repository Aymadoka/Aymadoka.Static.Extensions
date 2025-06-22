using System;
using System.ComponentModel;

namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// 将当前对象转换为指定类型 <typeparamref name="T"/>。
        /// </summary>
        /// <typeparam name="T">目标类型。</typeparam>
        /// <param name="this">要转换的对象。</param>
        /// <returns>转换后的对象。</returns>
        public static T To<T>(this object @this)
        {
            if (@this != null)
            {
                if (@this == DBNull.Value)
                {
                    return (T)(object)null;
                }

                Type targetType = typeof(T);

                if (@this.GetType() == targetType)
                {
                    return (T)@this;
                }

                TypeConverter converter = TypeDescriptor.GetConverter(@this);
                if (converter != null)
                {
                    if (converter.CanConvertTo(targetType))
                    {
                        return (T)converter.ConvertTo(@this, targetType);
                    }
                }

                converter = TypeDescriptor.GetConverter(targetType);
                if (converter != null)
                {
                    if (converter.CanConvertFrom(@this.GetType()))
                    {
                        return (T)converter.ConvertFrom(@this);
                    }
                }
            }

            return (T)@this;
        }

        /// <summary>
        /// 将当前对象转换为指定类型。
        /// </summary>
        /// <param name="this">要转换的对象。</param>
        /// <param name="type">目标类型。</param>
        /// <returns>转换后的对象。</returns>
        public static object To(this object @this, Type type)
        {
            if (@this != null)
            {
                if (@this == DBNull.Value)
                {
                    return null;
                }

                Type targetType = type;

                if (@this.GetType() == targetType)
                {
                    return @this;
                }

                TypeConverter converter = TypeDescriptor.GetConverter(@this);
                if (converter != null)
                {
                    if (converter.CanConvertTo(targetType))
                    {
                        return converter.ConvertTo(@this, targetType);
                    }
                }

                converter = TypeDescriptor.GetConverter(targetType);
                if (converter != null)
                {
                    if (converter.CanConvertFrom(@this.GetType()))
                    {
                        return converter.ConvertFrom(@this);
                    }
                }
            }

            return @this;
        }
    }
}
