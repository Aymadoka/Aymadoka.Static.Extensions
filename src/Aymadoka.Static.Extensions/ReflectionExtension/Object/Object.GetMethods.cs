using System.Reflection;

namespace Aymadoka.Static.ReflectionExtension
{
    public static partial class ObjectExtensions
    {
        public static MethodInfo[] GetMethods<T>(this T @this)
        {
            return @this.GetType().GetMethods();
        }

        public static MethodInfo[] GetMethods<T>(this T @this, BindingFlags bindingAttr)
        {
            return @this.GetType().GetMethods(bindingAttr);
        }
    }
}
