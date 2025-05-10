using System;
using System.Collections.Generic;
using System.IO;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        public static IEnumerable<DirectoryInfo> ForEach(this IEnumerable<DirectoryInfo> @this, Action<DirectoryInfo> action)
        {
            foreach (DirectoryInfo t in @this)
            {
                action(t);
            }
            return @this;
        }
    }
}
