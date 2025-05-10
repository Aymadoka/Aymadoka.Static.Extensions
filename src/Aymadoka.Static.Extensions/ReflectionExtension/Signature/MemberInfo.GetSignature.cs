using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Aymadoka.Static.ReflectionExtension
{
    public static partial class SignatureExtensions
    {
        public static string GetSignature(this MemberInfo @this)
        {
            switch (@this.MemberType)
            {
                case MemberTypes.Field:
                    return ((FieldInfo)@this).GetSignature();
                case MemberTypes.Property:
                    return ((PropertyInfo)@this).GetSignature();
                case MemberTypes.Constructor:
                    return ((ConstructorInfo)@this).GetSignature();
                case MemberTypes.Method:
                    return ((MethodInfo)@this).GetSignature();
                case MemberTypes.TypeInfo:
                    return ((Type)@this).GetSignature();
                case MemberTypes.NestedType:
                    return ((Type)@this).GetSignature();
                case MemberTypes.Event:
                    return ((EventInfo)@this).GetSignature();
                default:
                    return null;
            }
        }
    }
}
