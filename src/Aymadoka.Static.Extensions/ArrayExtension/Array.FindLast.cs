using System;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        public static T? FindLast<T>(this T[] array, Predicate<T> match)
        {
            return Array.FindLast(array, match);
        }
    }
}
