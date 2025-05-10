using System;

namespace Aymadoka.Static.ReflectionExtension
{
    public static partial class ObjectExtensions
    {
        public static bool IsTypeOrInheritsOf<T>(this T @this, Type type)
        {
            Type objectType = @this.GetType();

            while (true)
            {
                if (objectType.Equals(type))
                {
                    return true;
                }

                if ((objectType == objectType.BaseType) || (objectType.BaseType == null))
                {
                    return false;
                }

                objectType = objectType.BaseType;
            }
        }
    }
}
