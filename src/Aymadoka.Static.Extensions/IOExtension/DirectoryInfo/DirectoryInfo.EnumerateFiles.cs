using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension;

public static partial class DirectoryInfoExtensions
{
    public static IEnumerable<FileInfo> EnumerateFiles(this DirectoryInfo @this)
    {
        return Directory.EnumerateFiles(@this.FullName).Select(x => new FileInfo(x));
    }

    public static IEnumerable<FileInfo> EnumerateFiles(this DirectoryInfo @this, string searchPattern)
    {
        return Directory.EnumerateFiles(@this.FullName, searchPattern).Select(x => new FileInfo(x));
    }

    public static IEnumerable<FileInfo> EnumerateFiles(this DirectoryInfo @this, string searchPattern, SearchOption searchOption)
    {
        return Directory.EnumerateFiles(@this.FullName, searchPattern, searchOption).Select(x => new FileInfo(x));
    }

    public static IEnumerable<FileInfo> EnumerateFiles(this DirectoryInfo @this, string[] searchPatterns)
    {
        return searchPatterns.SelectMany(x => @this.GetFiles(x)).Distinct();
    }

    public static IEnumerable<FileInfo> EnumerateFiles(this DirectoryInfo @this, string[] searchPatterns, SearchOption searchOption)
    {
        return searchPatterns.SelectMany(x => @this.GetFiles(x, searchOption)).Distinct();
    }
}
