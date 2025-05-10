namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        public static bool IsHighSurrogate(this char c)
        {
            return char.IsHighSurrogate(c);
        }
    }
}
