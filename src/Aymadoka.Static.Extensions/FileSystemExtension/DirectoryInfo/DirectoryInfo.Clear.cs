using System;
using System.IO;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        public static void Clear(this DirectoryInfo obj)
        {
            Array.ForEach(obj.GetFiles(), x => x.Delete());
            Array.ForEach(obj.GetDirectories(), x => x.Delete(true));
        }
    }
}
