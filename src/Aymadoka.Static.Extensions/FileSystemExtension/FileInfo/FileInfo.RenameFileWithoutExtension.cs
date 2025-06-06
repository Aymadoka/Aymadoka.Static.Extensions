using System.IO;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        public static void RenameFileWithoutExtension(this FileInfo @this, string newName)
        {
            string fileName = string.Concat(newName, @this.Extension);
            string filePath = Path.Combine(@this.Directory.FullName, fileName);
            @this.MoveTo(filePath);
        }
    }
}
