using System;

namespace Aymadoka.Static.RandomExtension
{
    public static partial class RandomExtensions
    {
        public static T OneOf<T>(this Random @this, params T[] values)
        {
            return values[@this.Next(values.Length)];
        }
    }
}
