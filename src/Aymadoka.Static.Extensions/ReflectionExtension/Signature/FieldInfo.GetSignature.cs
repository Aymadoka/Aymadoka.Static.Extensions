using System;
using System.Linq;
using System.Reflection;
using System.Text;

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
