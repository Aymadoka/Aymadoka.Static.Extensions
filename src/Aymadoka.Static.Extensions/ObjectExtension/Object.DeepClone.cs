using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aymadoka.Static.ObjectExtension;

public static partial class ObjectExtensions
{
    public static T? DeepClone<T>(this T? @this) where T : class
    {
        if (@this == null)
        {
            return null;
        }

        var options = new JsonSerializerOptions
        {
            WriteIndented = false,
            TypeInfoResolver = null,
            ReferenceHandler = ReferenceHandler.IgnoreCycles
        };

        var json = JsonSerializer.Serialize(@this, options);
        return JsonSerializer.Deserialize<T>(json, options)!;
    }
}
