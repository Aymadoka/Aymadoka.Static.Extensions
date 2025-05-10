namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        public static string GetAfter(this string @this, string value)
        {
            if (@this.IndexOf(value) == -1)
            {
                return "";
            }

            return @this.Substring(@this.IndexOf(value) + value.Length);
        }
    }
}
