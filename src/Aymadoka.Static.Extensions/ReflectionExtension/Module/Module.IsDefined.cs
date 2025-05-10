using System.Reflection;
using System;

namespace Aymadoka.Static.ModuleExtension
{
    public static partial class ModuleExtensions
    {
        public static Boolean IsDefined(this Module element, Type attributeType)
        {
            return Attribute.IsDefined(element, attributeType);
        }

        public static Boolean IsDefined(this Module element, Type attributeType, Boolean inherit)
        {
            return Attribute.IsDefined(element, attributeType, inherit);
        }
    }
}
