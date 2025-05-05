using System;

namespace Aymadoka.Static.BooleanExtension
{
    public static partial class BooleanExtensions
    {
        public static void IfFalse(this bool @this, Action action)
        {
            if (!@this)
            {
                action();
            }
        }
    }
}
