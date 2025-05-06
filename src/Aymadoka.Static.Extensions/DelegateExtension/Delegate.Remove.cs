using System;

namespace Aymadoka.Static.DelegateExtension
{
    public static partial class DelegateExtensions
    {
        public static Delegate? Remove(this Delegate source, Delegate value)
        {
            return Delegate.Remove(source, value);
        }
    }
}
