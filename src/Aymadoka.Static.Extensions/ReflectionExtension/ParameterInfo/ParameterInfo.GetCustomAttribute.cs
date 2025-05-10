using System;
using System.Reflection;

namespace Aymadoka.Static.ParameterInfoExtension
{
    public static partial class ParameterInfoExtensions
    {
        public static Attribute GetCustomAttribute(this ParameterInfo element, Type attributeType)
        {
            return Attribute.GetCustomAttribute(element, attributeType);
        }

        public static Attribute GetCustomAttribute(this ParameterInfo element, Type attributeType, Boolean inherit)
        {
            return Attribute.GetCustomAttribute(element, attributeType, inherit);
        }
    }
}
