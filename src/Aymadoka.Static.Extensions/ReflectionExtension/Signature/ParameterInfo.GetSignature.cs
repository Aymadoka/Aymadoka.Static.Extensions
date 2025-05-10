using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Aymadoka.Static.ReflectionExtension
{
    public static partial class SignatureExtensions
    {
        public static string GetSignature(this ParameterInfo @this)
        {
            var sb = new StringBuilder();

            @this.GetSignature(sb);
            return sb.ToString();
        }

        internal static void GetSignature(this ParameterInfo @this, StringBuilder sb)
        {
            // retval attribute

            string typeName;
            Type elementType = @this.ParameterType.GetElementType();

            if (elementType != null)
            {
                typeName = @this.ParameterType.Name.Replace(elementType.Name, elementType.GetShortSignature());
            }
            else
            {
                typeName = @this.ParameterType.GetShortSignature();
            }

            if (@this.IsOut)
            {
                if (typeName.Contains("&"))
                {
                    typeName = typeName.Replace("&", "");
                    sb.Append("out ");
                }
            }
            else if (@this.ParameterType.IsByRef)
            {
                typeName = typeName.Replace("&", "");
                sb.Append("ref ");
            }
            sb.Append(typeName);
        }
    }
}
