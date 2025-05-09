using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Aymadoka.Static.ReflectionExtension;

public static partial class SignatureExtensions
{
    public static string GetSignature(this ConstructorInfo @this)
    {
        // Example:  [Name] [<GenericArguments] ([Parameters])
        var sb = new StringBuilder();

        // Name
        sb.Append(@this.ReflectedType.IsGenericType ? @this.ReflectedType.Name.Substring(0, @this.ReflectedType.Name.IndexOf('`')) : @this.ReflectedType.Name);

        // Parameters
        ParameterInfo[] parameters = @this.GetParameters();
        sb.Append("(");
        sb.Append(string.Join(", ", parameters.Select(x => x.GetSignature())));
        sb.Append(")");

        return sb.ToString();
    }
}
