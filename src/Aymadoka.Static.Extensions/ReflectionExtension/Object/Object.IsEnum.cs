namespace Aymadoka.Static.ReflectionExtension;

public static partial class ObjectExtensions
{
    public static bool IsEnum<T>(this T @this)
    {
        return @this.GetType().IsEnum;
    }
}
