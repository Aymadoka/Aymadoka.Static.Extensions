using System;
using System.Reflection;

namespace Aymadoka.Static.MemberInfoExtension;

public static partial class MemberInfoExtensions
{
    public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType)
    {
        return Attribute.GetCustomAttribute(element, attributeType);
    }

    public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType, Boolean inherit)
    {
        return Attribute.GetCustomAttribute(element, attributeType, inherit);
    }
}
