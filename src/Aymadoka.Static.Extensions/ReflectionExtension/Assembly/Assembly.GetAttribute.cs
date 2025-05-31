using System;
using System.Reflection;

namespace Aymadoka.Static.AssemblyExtension
{
    public static partial class AssemblyExtensions
    {
        public static T GetAttribute<T>(this Assembly @this) where T : Attribute
        {
            object[] configAttributes = Attribute.GetCustomAttributes(@this, typeof(T), false);

            if (configAttributes != null && configAttributes.Length > 0)
            {
                return (T)configAttributes[0];
            }

            return null;
        }
    }
}
