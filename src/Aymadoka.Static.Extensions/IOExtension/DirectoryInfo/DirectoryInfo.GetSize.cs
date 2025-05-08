using System;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension;

public static partial class DirectoryInfoExtensions
{
    public static long GetSize(this DirectoryInfo @this)
    {
        return @this.GetFiles("*.*", SearchOption.AllDirectories).Sum(x => x.Length);
    }
}
