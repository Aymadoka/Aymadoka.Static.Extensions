using System.IO;

namespace Aymadoka.Static.StreamReaderExtension
{
    public static partial class StreamReaderExtensions
    {
        public static void SkipLines(this StreamReader @this, int skipCount)
        {
            for (var i = 0; i < skipCount && !@this.EndOfStream; i++)
            {
                @this.ReadLine();
            }
        }
    }
}
