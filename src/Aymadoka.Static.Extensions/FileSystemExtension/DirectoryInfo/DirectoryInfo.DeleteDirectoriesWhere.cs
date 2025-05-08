using Aymadoka.Static.EnumerableExtension;
using System;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        public static void DeleteDirectoriesWhere(this DirectoryInfo obj, Func<DirectoryInfo, bool> predicate)
        {
            obj.GetDirectories().Where(predicate).ForEach(x => x.Delete());
        }

        public static void DeleteDirectoriesWhere(this DirectoryInfo obj, SearchOption searchOption, Func<DirectoryInfo, bool> predicate)
        {
            obj.GetDirectories("*.*", searchOption).Where(predicate).ForEach(x => x.Delete());
        }
    }
}
