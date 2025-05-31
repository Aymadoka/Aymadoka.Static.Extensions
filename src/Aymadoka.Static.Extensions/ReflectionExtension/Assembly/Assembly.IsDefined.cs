using System;
using System.Reflection;

namespace Aymadoka.Static.AssemblyExtension
{
    public static partial class AssemblyExtensions
    {
        public static bool IsDefined(this Assembly element, Type attributeType)
        {
            return Attribute.IsDefined(element, attributeType);
        }

        public static bool IsDefined(this Assembly element, Type attributeType, bool inherit)
        {
            return Attribute.IsDefined(element, attributeType, inherit);
        }
    }
}
