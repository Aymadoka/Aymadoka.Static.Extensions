using System.Text;
using System;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        public static byte[] ToByteArray(this string @this)
        {
            var encoding = Activator.CreateInstance<UTF8Encoding>();
            return encoding.GetBytes(@this);
        }
    }
}
