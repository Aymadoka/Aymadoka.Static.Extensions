using System;
using System.Reflection;

namespace Aymadoka.Static.AssemblyExtension
{
    public static partial class AssemblyExtensions
    {
        public static Attribute[] GetCustomAttributes(this Assembly element, Type attributeType)
        {
            return Attribute.GetCustomAttributes(element, attributeType);
        }

        public static Attribute[] GetCustomAttributes(this Assembly element, Type attributeType, Boolean inherit)
        {
            return Attribute.GetCustomAttributes(element, attributeType, inherit);
        }

        public static Attribute[] GetCustomAttributes(this Assembly element)
        {
            return Attribute.GetCustomAttributes(element);
        }

        public static Attribute[] GetCustomAttributes(this Assembly element, Boolean inherit)
        {
            return Attribute.GetCustomAttributes(element, inherit);
        }
    }
}
