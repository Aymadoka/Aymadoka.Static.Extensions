using System;
using System.Reflection;

namespace Aymadoka.Static.ParameterInfoExtension
{
    public static partial class ParameterInfoExtensions
    {
        public static Attribute[] GetCustomAttributes(this ParameterInfo element)
        {
            return Attribute.GetCustomAttributes(element);
        }

        public static Attribute[] GetCustomAttributes(this ParameterInfo element, Type attributeType)
        {
            return Attribute.GetCustomAttributes(element, attributeType);
        }

        public static Attribute[] GetCustomAttributes(this ParameterInfo element, Type attributeType, Boolean inherit)
        {
            return Attribute.GetCustomAttributes(element, attributeType, inherit);
        }

        public static Attribute[] GetCustomAttributes(this ParameterInfo element, Boolean inherit)
        {
            return Attribute.GetCustomAttributes(element, inherit);
        }
    }
}
