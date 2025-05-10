using Aymadoka.Static.EnumerableExtension;
using System;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        public static void DeleteOlderThan(this DirectoryInfo obj, TimeSpan timeSpan)
        {
            DateTime minDate = DateTime.Now.Subtract(timeSpan);
            obj.GetFiles().Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
            obj.GetDirectories().Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
        }

        public static void DeleteOlderThan(this DirectoryInfo obj, SearchOption searchOption, TimeSpan timeSpan)
        {
            DateTime minDate = DateTime.Now.Subtract(timeSpan);
            obj.GetFiles("*.*", searchOption).Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
            obj.GetDirectories("*.*", searchOption).Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
        }
    }
}
