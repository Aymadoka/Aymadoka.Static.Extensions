using System.Collections.Generic;

namespace Aymadoka.Static.ObjectExtension;

public static partial class ObjectExtensions
{
    public static bool IsDefault<T>(this T @this)
    {
        var result = EqualityComparer<T>.Default.Equals(@this, default!);
        return result;
    }
}
