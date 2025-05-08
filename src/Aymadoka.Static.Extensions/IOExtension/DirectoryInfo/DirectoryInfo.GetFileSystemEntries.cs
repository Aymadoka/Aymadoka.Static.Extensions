using System;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension;

public static partial class DirectoryInfoExtensions
{
    public static string[] GetFileSystemEntries(this DirectoryInfo @this)
    {
        return Directory.EnumerateFileSystemEntries(@this.FullName).ToArray();
    }

    public static string[] GetFileSystemEntries(this DirectoryInfo @this, String searchPattern)
    {
        return Directory.EnumerateFileSystemEntries(@this.FullName, searchPattern).ToArray();
    }

    public static string[] GetFileSystemEntries(this DirectoryInfo @this, String searchPattern, SearchOption searchOption)
    {
        return Directory.EnumerateFileSystemEntries(@this.FullName, searchPattern, searchOption).ToArray();
    }

    public static string[] GetFileSystemEntries(this DirectoryInfo @this, String[] searchPatterns)
    {
        return searchPatterns.SelectMany(x => Directory.EnumerateFileSystemEntries(@this.FullName, x)).Distinct().ToArray();
    }

    public static string[] GetFileSystemEntries(this DirectoryInfo @this, String[] searchPatterns, SearchOption searchOption)
    {
        return searchPatterns.SelectMany(x => Directory.EnumerateFileSystemEntries(@this.FullName, x, searchOption)).Distinct().ToArray();
    }
}
