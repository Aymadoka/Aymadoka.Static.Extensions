using System.Security;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        public static SecureString ToSecureString(this string @this)
        {
            var secureString = new SecureString();
            foreach (char c in @this)
                secureString.AppendChar(c);

            return secureString;
        }
    }
}
