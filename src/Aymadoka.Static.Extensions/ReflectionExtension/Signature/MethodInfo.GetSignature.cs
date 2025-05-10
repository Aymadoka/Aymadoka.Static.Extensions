using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Aymadoka.Static.ReflectionExtension
{
    public static partial class SignatureExtensions
    {
        public static string GetSignature(this MethodInfo @this)
        {
            // Example: [Visibility] [Modifier] [Type] [Name] [<GenericArguments] ([Parameters])
            var sb = new StringBuilder();

            // Name
            sb.Append(@this.Name);

            if (@this.IsGenericMethod)
            {
                sb.Append("<");

                Type[] arguments = @this.GetGenericArguments();

                sb.Append(string.Join(", ", arguments.Select(x => x.GetShortSignature())));

                sb.Append(">");
            }

            // Parameters
            ParameterInfo[] parameters = @this.GetParameters();
            sb.Append("(");
            sb.Append(string.Join(", ", parameters.Select(x => x.GetSignature())));
            sb.Append(")");

            return sb.ToString();
        }
    }
}
