using Aymadoka.Static.EnumerableExtension;
using System;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension;

public static partial class DirectoryInfoExtensions
{
    public static void DeleteFilesWhere(this DirectoryInfo obj, Func<FileInfo, bool> predicate)
    {
        obj.GetFiles().Where(predicate).ForEach(x => x.Delete());
    }

    public static void DeleteFilesWhere(this DirectoryInfo obj, SearchOption searchOption, Func<FileInfo, bool> predicate)
    {
        obj.GetFiles("*.*", searchOption).Where(predicate).ForEach(x => x.Delete());
    }
}
