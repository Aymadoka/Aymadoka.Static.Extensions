using System.IO;

namespace Aymadoka.Static.StreamReaderExtension
{
    public static partial class StreamReaderExtensions
    {
        /// <summary>
        /// 跳过指定数量的行。
        /// </summary>
        /// <param name="this">要操作的 <see cref="StreamReader"/> 实例。</param>
        /// <param name="skipCount">要跳过的行数。</param>
        public static void SkipLines(this StreamReader @this, int skipCount)
        {
            for (var i = 0; i < skipCount && !@this.EndOfStream; i++)
            {
                @this.ReadLine();
            }
        }
    }
}
