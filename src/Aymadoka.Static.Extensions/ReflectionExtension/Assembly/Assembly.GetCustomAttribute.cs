using System;
using System.Reflection;

namespace Aymadoka.Static.AssemblyExtension
{
    public static partial class AssemblyExtensions
    {
        public static Attribute GetCustomAttribute(this Assembly element, Type attributeType)
        {
            return Attribute.GetCustomAttribute(element, attributeType);
        }

        public static Attribute GetCustomAttribute(this Assembly element, Type attributeType, Boolean inherit)
        {
            return Attribute.GetCustomAttribute(element, attributeType, inherit);
        }
    }
}
