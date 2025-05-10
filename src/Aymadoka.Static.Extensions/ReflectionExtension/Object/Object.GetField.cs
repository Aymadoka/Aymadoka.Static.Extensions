using System.Reflection;

namespace Aymadoka.Static.ReflectionExtension
{
    public static partial class ObjectExtensions
    {
        public static FieldInfo GetField<T>(this T @this, string name)
        {
            return @this.GetType().GetField(name);
        }

        public static FieldInfo GetField<T>(this T @this, string name, BindingFlags bindingAttr)
        {
            return @this.GetType().GetField(name, bindingAttr);
        }
    }
}
