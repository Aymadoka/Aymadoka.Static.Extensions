using System;

namespace Aymadoka.Static.GuidExtension
{
    public static partial class GuidExtensions
    {
        public static bool IsNotEmpty(this Guid @this)
        {
            return @this != Guid.Empty;
        }
    }
}
