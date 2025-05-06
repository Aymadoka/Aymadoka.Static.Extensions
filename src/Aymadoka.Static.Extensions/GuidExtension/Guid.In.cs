using System;

namespace Aymadoka.Static.GuidExtension
{
    public static partial class GuidExtensions
    {
        public static bool In(this Guid @this, params Guid[] values)
        {
            return Array.IndexOf(values, @this) != -1;
        }
    }
}
