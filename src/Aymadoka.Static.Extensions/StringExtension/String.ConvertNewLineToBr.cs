namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        public static string Nl2Br(this string @this)
        {
            return @this.Replace("\r\n", "<br />").Replace("\n", "<br />");
        }
    }
}
