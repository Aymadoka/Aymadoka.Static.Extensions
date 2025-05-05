using System;

namespace Aymadoka.Static.BooleanExtension
{
    public static partial class BooleanExtensions
    {
        public static byte ToByte(this bool @this)
        {
            return Convert.ToByte(@this);
        }
    }
}
