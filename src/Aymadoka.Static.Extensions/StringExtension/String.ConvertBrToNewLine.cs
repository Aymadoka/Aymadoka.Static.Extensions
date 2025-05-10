namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        public static string ConvertBrToNewLine(this string @this)
        {
            return @this.Replace("<br />", "\r\n").Replace("<br>", "\r\n");
        }
    }
}
