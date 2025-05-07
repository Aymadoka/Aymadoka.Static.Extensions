using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.ObjectExtension;

public static partial class ObjectExtensions
{
    public static bool IsNotNull<T>([NotNullWhen(true)] this T? source) where T : class
    {
        return !source.IsNull();
    }
}
