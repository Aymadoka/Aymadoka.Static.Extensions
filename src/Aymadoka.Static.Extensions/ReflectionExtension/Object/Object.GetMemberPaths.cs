using System.Collections.Generic;
using System;
using System.Reflection;

namespace Aymadoka.Static.ReflectionExtension;

public static partial class ObjectExtensions
{
    public static MemberInfo[] GetMemberPaths<T>(this T @this, string path)
    {
        Type lastType = @this.GetType();
        string[] paths = path.Split('.');

        var memberPaths = new List<MemberInfo>();

        foreach (string item in paths)
        {
            PropertyInfo propertyInfo = lastType.GetProperty(item);
            FieldInfo fieldInfo = lastType.GetField(item);

            if (propertyInfo != null)
            {
                memberPaths.Add(propertyInfo);
                lastType = propertyInfo.PropertyType;
            }
            if (fieldInfo != null)
            {
                memberPaths.Add(fieldInfo);
                lastType = fieldInfo.FieldType;
            }
        }

        return memberPaths.ToArray();
    }
}
