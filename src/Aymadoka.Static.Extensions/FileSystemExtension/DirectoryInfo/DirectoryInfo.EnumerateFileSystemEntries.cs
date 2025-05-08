using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension;

public static partial class DirectoryInfoExtensions
{
    public static IEnumerable<string> EnumerateFileSystemEntries(this DirectoryInfo @this)
    {
        return Directory.EnumerateFileSystemEntries(@this.FullName);
    }

    public static IEnumerable<string> EnumerateFileSystemEntries(this DirectoryInfo @this, string searchPattern)
    {
        return Directory.EnumerateFileSystemEntries(@this.FullName, searchPattern);
    }

    public static IEnumerable<string> EnumerateFileSystemEntries(this DirectoryInfo @this, string searchPattern, SearchOption searchOption)
    {
        return Directory.EnumerateFileSystemEntries(@this.FullName, searchPattern, searchOption);
    }

    public static IEnumerable<string> EnumerateFileSystemEntries(this DirectoryInfo @this, string[] searchPatterns)
    {
        return searchPatterns.SelectMany(x => Directory.EnumerateFileSystemEntries(@this.FullName, x)).Distinct();
    }

    public static IEnumerable<string> EnumerateFileSystemEntries(this DirectoryInfo @this, string[] searchPatterns, SearchOption searchOption)
    {
        return searchPatterns.SelectMany(x => Directory.EnumerateFileSystemEntries(@this.FullName, x, searchOption)).Distinct();
    }
}
