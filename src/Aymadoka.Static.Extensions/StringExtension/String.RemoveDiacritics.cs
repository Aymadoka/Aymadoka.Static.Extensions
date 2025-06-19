using System;
using System.Globalization;
using System.Text;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 移除字符串中的变音符号（重音符号），返回不带变音符号的新字符串。
        /// </summary>
        /// <param name="this">要处理的字符串。</param>
        /// <returns>移除变音符号后的字符串。</returns>
        public static string RemoveDiacritics(this string @this)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            // 将字符串标准化为分解形式（FormD），以便分离出变音符号
            string normalizedString = @this.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();

            // 遍历每个字符，跳过所有非间距标记（即变音符号）
            foreach (char t in normalizedString)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(t);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(t);
                }
            }

            // 将结果重新标准化为组合形式（FormC）并返回
            return sb.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
