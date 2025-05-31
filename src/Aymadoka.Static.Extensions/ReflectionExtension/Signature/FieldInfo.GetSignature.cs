using System.Reflection;

namespace Aymadoka.Static.ReflectionExtension
{
    public static partial class SignatureExtensions
    {
        public static string GetSignature(this FieldInfo @this)
        {
            return @this.Name;
        }
    }
}
