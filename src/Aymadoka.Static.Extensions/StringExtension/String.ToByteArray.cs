using System;
using System.Text;

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
