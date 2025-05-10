namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        public static string FormatWith(this string @this, object arg0)
        {
            return string.Format(@this, arg0);
        }

        public static string FormatWith(this string @this, object arg0, object arg1)
        {
            return string.Format(@this, arg0, arg1);
        }

        public static string FormatWith(this string @this, object arg0, object arg1, object arg2)
        {
            return string.Format(@this, arg0, arg1, arg2);
        }

        public static string FormatWith(this string @this, params object[] values)
        {
            return string.Format(@this, values);
        }
    }
}
