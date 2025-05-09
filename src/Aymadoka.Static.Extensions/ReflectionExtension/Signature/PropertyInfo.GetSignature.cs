using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Aymadoka.Static.ReflectionExtension;

public static partial class SignatureExtensions
{
    public static string GetSignature(this PropertyInfo @this)
    {
        // Example: [Name | Indexer[Type]]

        var indexerParameter = @this.GetIndexParameters();
        if (indexerParameter.Length == 0)
        {
            // Name
            return @this.Name;
        }
        var sb = new StringBuilder();

        // Indexer
        sb.Append(@this.Name);
        sb.Append("[");
        sb.Append(string.Join(", ", indexerParameter.Select(x => x.ParameterType.GetShortSignature())));
        sb.Append("]");

        return sb.ToString();
    }
}
