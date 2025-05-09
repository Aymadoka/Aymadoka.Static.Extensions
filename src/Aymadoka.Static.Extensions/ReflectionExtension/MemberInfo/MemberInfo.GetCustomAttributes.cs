using System;
using System.Reflection;

namespace Aymadoka.Static.MemberInfoExtension;

public static partial class MemberInfoExtensions
{
    public static Attribute[] GetCustomAttributes(this MemberInfo element, Type type)
    {
        return Attribute.GetCustomAttributes(element, type);
    }

    public static Attribute[] GetCustomAttributes(this MemberInfo element, Type type, Boolean inherit)
    {
        return Attribute.GetCustomAttributes(element, type, inherit);
    }

    public static Attribute[] GetCustomAttributes(this MemberInfo element)
    {
        return Attribute.GetCustomAttributes(element);
    }

    public static Attribute[] GetCustomAttributes(this MemberInfo element, Boolean inherit)
    {
        return Attribute.GetCustomAttributes(element, inherit);
    }
}
