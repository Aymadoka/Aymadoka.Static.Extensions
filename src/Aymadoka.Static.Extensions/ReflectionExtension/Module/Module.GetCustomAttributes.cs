using System.Reflection;
using System;

namespace Aymadoka.Static.ModuleExtension
{
    public static partial class ModuleExtensions
    {
        public static Attribute[] GetCustomAttributes(this Module element, Type attributeType)
        {
            return Attribute.GetCustomAttributes(element, attributeType);
        }

        public static Attribute[] GetCustomAttributes(this Module element)
        {
            return Attribute.GetCustomAttributes(element);
        }

        public static Attribute[] GetCustomAttributes(this Module element, Boolean inherit)
        {
            return Attribute.GetCustomAttributes(element, inherit);
        }

        public static Attribute[] GetCustomAttributes(this Module element, Type attributeType, Boolean inherit)
        {
            return Attribute.GetCustomAttributes(element, attributeType, inherit);
        }
    }
}
