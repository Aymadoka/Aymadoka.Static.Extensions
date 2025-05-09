using System;
using System.Reflection;

namespace Aymadoka.Static.ParameterInfoExtension;

public static partial class ParameterInfoExtensions
{
    public static Boolean IsDefined(this ParameterInfo element, Type attributeType)
    {
        return Attribute.IsDefined(element, attributeType);
    }

    public static Boolean IsDefined(this ParameterInfo element, Type attributeType, Boolean inherit)
    {
        return Attribute.IsDefined(element, attributeType, inherit);
    }
}
