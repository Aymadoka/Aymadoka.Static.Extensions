using System.IO;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        public static FileInfo ToFileInfo(this string @this)
        {
            return new FileInfo(@this);
        }
    }
}
