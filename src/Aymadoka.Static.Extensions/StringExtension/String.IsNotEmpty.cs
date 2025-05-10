namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        public static bool IsNotEmpty(this string? @this)
        {
            return string.Empty != @this;
        }
    }
}
