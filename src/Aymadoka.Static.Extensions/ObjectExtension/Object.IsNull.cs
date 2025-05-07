using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.ObjectExtension;

public static partial class ObjectExtensions
{
    public static bool IsNull<T>([NotNullWhen(false)] this T? source) where T : class
    {
        return source == null;
    }
}
