using System;

namespace Aymadoka.Static.EncodingExtension
{
    public static partial class EncodingExtensions
    {
        public static byte[] FromStringToBytes(this string @this)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(@this);
            return bytes;
        }
    }
}
