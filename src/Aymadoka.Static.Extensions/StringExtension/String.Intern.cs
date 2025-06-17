namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
    /// <summary>
    /// 为字符串调用 <see cref="string.Intern(string)"/> 方法，将指定的字符串添加到公共引用表中并返回对该字符串的引用。
    /// </summary>
    /// <param name="str">要驻留的字符串。</param>
    /// <returns>如果字符串已存在于公共引用表中，则返回该字符串的引用；否则将其添加到表中并返回引用。</returns>
        public static string Intern(this string str)
        {
            return string.Intern(str);
        }
    }
}
