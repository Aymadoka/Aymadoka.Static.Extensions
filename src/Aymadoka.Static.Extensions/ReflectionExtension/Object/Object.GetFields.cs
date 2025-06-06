using System.Reflection;

namespace Aymadoka.Static.ReflectionExtension
{
    public static partial class ObjectExtensions
    {
        public static FieldInfo[] GetFields(this object @this)
        {
            return @this.GetType().GetFields();
        }

        /// <summary>An object extension method that gets the fields.</summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="bindingAttr">The binding attribute.</param>
        /// <returns>An array of field information.</returns>
        public static FieldInfo[] GetFields(this object @this, BindingFlags bindingAttr)
        {
            return @this.GetType().GetFields(bindingAttr);
        }
    }
}
