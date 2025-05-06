using System;

namespace Aymadoka.Static.EncodingExtension
{
    public static partial class EncodingExtensions
    {
        public static byte[] FromStringToBytes(this string @this)
        {
            ArgumentNullException.ThrowIfNull(@this);

            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(@this);
            return bytes;
        }
    }
}
