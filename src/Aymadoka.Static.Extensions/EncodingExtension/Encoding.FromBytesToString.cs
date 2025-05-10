using Aymadoka.Static.EnumerableExtension;
using Aymadoka.Static.StringExtension;
using System;

namespace Aymadoka.Static.EncodingExtension
{
    public static partial class EncodingExtensions
    {
        public static string FromBytesToString(this byte[] @this)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            string result = System.Text.Encoding.UTF8.GetString(@this);
            return result;
        }
    }
}
