using System;

namespace Aymadoka.Static.DelegateExtension
{
    public static partial class DelegateExtensions
    {
        public static Delegate Combine(this Delegate a, Delegate b)
        {
            return Delegate.Combine(a, b);
        }
    }
}
