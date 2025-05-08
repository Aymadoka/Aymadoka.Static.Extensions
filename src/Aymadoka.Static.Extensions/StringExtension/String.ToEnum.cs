using System;

namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static T ToEnum<T>(this string @this)
    {
        Type enumType = typeof(T);
        return (T)Enum.Parse(enumType, @this);
    }
}
