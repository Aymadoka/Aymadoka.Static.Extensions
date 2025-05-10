namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        public static string IfEmpty(this string @this, string defaultValue)
        {
            if (@this.IsEmpty())
            {
                return defaultValue;
            }

            return @this;
        }
    }
}
