using System;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        public static XDocument ToXDocument(this string @this)
        {
            Encoding encoding = Activator.CreateInstance<UTF8Encoding>();
            using (var ms = new MemoryStream(encoding.GetBytes(@this)))
            {
                return XDocument.Load(ms);
            }
        }
    }
}
