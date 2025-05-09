using System.Reflection;

namespace Aymadoka.Static.ReflectionExtension;

public static partial class ObjectExtensions
{
    public static MethodInfo GetMethod<T>(this T @this, string name)
    {
        return @this.GetType().GetMethod(name);
    }

    public static MethodInfo GetMethod<T>(this T @this, string name, BindingFlags bindingAttr)
    {
        return @this.GetType().GetMethod(name, bindingAttr);
    }
}
