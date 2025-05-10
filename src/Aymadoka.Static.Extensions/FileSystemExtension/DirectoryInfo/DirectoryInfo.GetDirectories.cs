using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        public static DirectoryInfo[] GetDirectories(this DirectoryInfo @this, string[] searchPatterns)
        {
            return searchPatterns.SelectMany(x => @this.GetDirectories(x)).Distinct().ToArray();
        }

        public static DirectoryInfo[] GetDirectories(this DirectoryInfo @this, string[] searchPatterns, SearchOption searchOption)
        {
            return searchPatterns.SelectMany(x => @this.GetDirectories(x, searchOption)).Distinct().ToArray();
        }
    }
}
