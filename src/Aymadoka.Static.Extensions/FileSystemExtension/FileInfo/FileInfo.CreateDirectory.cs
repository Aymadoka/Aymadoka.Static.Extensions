using System.IO;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        public static DirectoryInfo CreateDirectory(this FileInfo @this)
        {
            return Directory.CreateDirectory(@this.Directory.FullName);
        }
    }
}
