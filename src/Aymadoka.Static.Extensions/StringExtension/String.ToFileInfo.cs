using System.IO;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 将字符串路径转换为 <see cref="FileInfo"/> 实例。
        /// </summary>
        /// <param name="this">要转换的文件路径字符串。</param>
        /// <returns>表示该路径的 <see cref="FileInfo"/> 实例。</returns>
        public static FileInfo ToFileInfo(this string @this)
        {
            return new FileInfo(@this);
        }
    }
}
