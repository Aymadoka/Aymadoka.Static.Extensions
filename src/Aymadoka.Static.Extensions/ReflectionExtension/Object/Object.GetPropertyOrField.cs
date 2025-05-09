using System.Reflection;

namespace Aymadoka.Static.ReflectionExtension;

public static partial class ObjectExtensions
{
    public static MemberInfo GetPropertyOrField<T>(this T @this, string name)
    {
        PropertyInfo property = @this.GetProperty(name);
        if (property != null)
        {
            return property;
        }

        FieldInfo field = @this.GetField(name);
        if (field != null)
        {
            return field;
        }

        return null;
    }
}
