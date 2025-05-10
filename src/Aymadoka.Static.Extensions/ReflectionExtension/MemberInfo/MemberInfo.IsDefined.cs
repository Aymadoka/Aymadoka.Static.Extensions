using System;
using System.Reflection;

namespace Aymadoka.Static.MemberInfoExtension
{
    public static partial class MemberInfoExtensions
    {
        public static Boolean IsDefined(this MemberInfo element, Type attributeType)
        {
            return Attribute.IsDefined(element, attributeType);
        }

        public static Boolean IsDefined(this MemberInfo element, Type attributeType, Boolean inherit)
        {
            return Attribute.IsDefined(element, attributeType, inherit);
        }
    }
}
