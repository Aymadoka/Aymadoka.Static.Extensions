using System;

namespace Aymadoka.Static.ReflectionExtension;

public static partial class SignatureExtensions
{
    internal static string GetShortSignature(this Type @this)
    {
        if (@this == typeof(bool))
        {
            return "bool";
        }
        if (@this == typeof(byte))
        {
            return "byte";
        }
        if (@this == typeof(char))
        {
            return "char";
        }
        if (@this == typeof(decimal))
        {
            return "decimal";
        }
        if (@this == typeof(double))
        {
            return "double";
        }
        if (@this == typeof(Enum))
        {
            return "enum";
        }
        if (@this == typeof(float))
        {
            return "float";
        }
        if (@this == typeof(int))
        {
            return "int";
        }
        if (@this == typeof(long))
        {
            return "long";
        }
        if (@this == typeof(object))
        {
            return "object";
        }
        if (@this == typeof(sbyte))
        {
            return "sbyte";
        }
        if (@this == typeof(short))
        {
            return "short";
        }
        if (@this == typeof(string))
        {
            return "string";
        }
        if (@this == typeof(uint))
        {
            return "uint";
        }
        if (@this == typeof(ulong))
        {
            return "ulong";
        }
        if (@this == typeof(ushort))
        {
            return "ushort";
        }

        return @this.Name;
    }
}
