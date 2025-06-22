using System;
using System.Linq;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 移除字符串中的所有 Unicode 字母字符（包括大写、小写字母及其他 Unicode 字母，如中文等）。
        /// </summary>
        /// <param name="this">要处理的字符串实例。</param>
        /// <returns>移除所有字母（包括中文等 Unicode 字母）后的新字符串。如果原字符串为 null，则返回空字符串。</returns>
        public static string RemoveLetter(this string @this)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            var result = new string(@this.ToCharArray().Where(x => !char.IsLetter(x)).ToArray());
            return result;
        }
    }
}
