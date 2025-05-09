namespace Aymadoka.Static.ReflectionExtension;

public static partial class ObjectExtensions
{
    public static bool IsClass<T>(this T @this)
    {
        return @this.GetType().IsClass;
    }
}
