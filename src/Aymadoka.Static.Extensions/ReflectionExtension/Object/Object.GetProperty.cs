using System.Reflection;

namespace Aymadoka.Static.ReflectionExtension
{
    public static partial class ObjectExtensions
    {
        public static PropertyInfo GetProperty<T>(this T @this, string name)
        {
            return @this.GetType().GetProperty(name);
        }

        public static PropertyInfo GetProperty<T>(this T @this, string name, BindingFlags bindingAttr)
        {
            return @this.GetType().GetProperty(name, bindingAttr);
        }
    }
}
