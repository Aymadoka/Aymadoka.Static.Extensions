using System.Reflection;

namespace Aymadoka.Static.ReflectionExtension;

public static partial class ObjectExtensions
{
    public static PropertyInfo[] GetProperties(this object @this)
    {
        return @this.GetType().GetProperties();
    }

    public static PropertyInfo[] GetProperties(this object @this, BindingFlags bindingAttr)
    {
        return @this.GetType().GetProperties(bindingAttr);
    }
}
