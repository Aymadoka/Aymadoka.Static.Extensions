using System;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        public static bool WithinIndex<T>(this T[] @this, int index)
        {
            return index >= 0 && index < @this.Length;
        }

        public static bool WithinIndex<T>(this T[] @this, int index, int dimension)
        {
            return index >= @this.GetLowerBound(dimension) && index <= @this.GetUpperBound(dimension);
        }
    }
}
