using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Aymadoka.Static.ReflectionExtension
{
    public static partial class SignatureExtensions
    {
        public static string GetSignature(this Type @this)
        {
            // Example: [Visibility] [Modifier] [Type] [Name] [<GenericArguments>] [:] [Inherited Class] [Inherited Interface]
            var sb = new StringBuilder();

            // Variable
            bool hasInheritedClass = false;

            // Name
            sb.Append(@this.IsGenericType ? @this.Name.Substring(0, @this.Name.IndexOf('`')) : @this.Name);

            // GenericArguments
            if (@this.IsGenericType)
            {
                Type[] arguments = @this.GetGenericArguments();
                sb.Append("<");
                sb.Append(string.Join(", ", arguments.Select(x =>
                {
                    Type[] constraints = x.GetGenericParameterConstraints();

                    foreach (Type constraint in constraints)
                    {
                        GenericParameterAttributes gpa = constraint.GenericParameterAttributes;
                        GenericParameterAttributes variance = gpa & GenericParameterAttributes.VarianceMask;

                        if (variance != GenericParameterAttributes.None)
                        {
                            sb.Append((variance & GenericParameterAttributes.Covariant) != 0 ? "in " : "out ");
                        }
                    }

                    return x.GetShortDeclaraction();
                })));
                sb.Append(">");
            }

            return sb.ToString();
        }
    }
}
