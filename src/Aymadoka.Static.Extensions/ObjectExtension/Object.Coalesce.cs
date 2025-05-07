namespace Aymadoka.Static.ObjectExtension;

public static partial class ObjectExtensions
{
    public static T? Coalesce<T>(this T? @this, params T[] values) where T : class
    {
        if (@this != null)
        {
            return @this;
        }

        foreach (T value in values)
        {
            if (value != null)
            {
                return value;
            }
        }

        return null;
    }
}
