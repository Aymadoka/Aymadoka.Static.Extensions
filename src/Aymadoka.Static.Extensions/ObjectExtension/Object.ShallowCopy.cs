using System;
using System.Reflection;

namespace Aymadoka.Static.ObjectExtension;

public static partial class ObjectExtensions
{
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
        MethodInfo? method = @this.GetType().GetMethod("MemberwiseClone", bindingAttr);
        if (method == null)
        {
            throw new InvalidOperationException($"The type {typeof(T).FullName} does not support shallow copying.");
        }

        var response = method.Invoke(@this, null);
        var result = response!.As<T>();
        return result;
    }
}
