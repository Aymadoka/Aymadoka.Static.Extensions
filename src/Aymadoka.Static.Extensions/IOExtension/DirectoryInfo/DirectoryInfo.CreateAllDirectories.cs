using System.IO;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        public static DirectoryInfo CreateAllDirectories(this DirectoryInfo @this)
        {
            return Directory.CreateDirectory(@this.FullName);
        }
    }
}
