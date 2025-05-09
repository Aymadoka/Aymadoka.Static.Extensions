using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Aymadoka.Static.AssemblyExtension;

public static partial class AssemblyExtensions
{
    public static Attribute GetCustomAttribute(this Assembly element, Type attributeType)
    {
        return Attribute.GetCustomAttribute(element, attributeType);
    }

    public static Attribute GetCustomAttribute(this Assembly element, Type attributeType, Boolean inherit)
    {
        return Attribute.GetCustomAttribute(element, attributeType, inherit);
    }
}
