namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        public static string Format(this string format, object arg0)
        {
            return string.Format(format, arg0);
        }

        public static string Format(this string format, object arg0, object arg1)
        {
            return string.Format(format, arg0, arg1);
        }

        public static string Format(this string format, object arg0, object arg1, object arg2)
        {
            return string.Format(format, arg0, arg1, arg2);
        }

        public static string Format(this string format, object[] args)
        {
            return string.Format(format, args);
        }
    }
}
