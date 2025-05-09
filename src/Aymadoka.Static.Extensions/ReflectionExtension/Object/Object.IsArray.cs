namespace Aymadoka.Static.ReflectionExtension;

public static partial class ObjectExtensions
{
    public static bool IsArray<T>(this T @this)
    {
        return @this.GetType().IsArray;
    }
}
