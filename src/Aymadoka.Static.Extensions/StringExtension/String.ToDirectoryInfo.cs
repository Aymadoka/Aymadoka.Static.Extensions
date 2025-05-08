using System.IO;

namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static DirectoryInfo ToDirectoryInfo(this string @this)
    {
        return new DirectoryInfo(@this);
    }
}
