using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aymadoka.Static.FileInfoExtension;

public static partial class FileInfoExtensions
{
    public static string ReadToEnd(this FileInfo @this)
    {
        using (FileStream stream = File.Open(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
            using (var reader = new StreamReader(stream, Encoding.Default))
            {
                return reader.ReadToEnd();
            }
        }
    }

    public static string ReadToEnd(this FileInfo @this, long position)
    {
        using (FileStream stream = File.Open(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
            stream.Position = position;

            using (var reader = new StreamReader(stream, Encoding.Default))
            {
                return reader.ReadToEnd();
            }
        }
    }

    public static string ReadToEnd(this FileInfo @this, Encoding encoding)
    {
        using (FileStream stream = File.Open(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
            using (var reader = new StreamReader(stream, encoding))
            {
                return reader.ReadToEnd();
            }
        }
    }

    public static string ReadToEnd(this FileInfo @this, Encoding encoding, long position)
    {
        using (FileStream stream = File.Open(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
            stream.Position = position;

            using (var reader = new StreamReader(stream, encoding))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
