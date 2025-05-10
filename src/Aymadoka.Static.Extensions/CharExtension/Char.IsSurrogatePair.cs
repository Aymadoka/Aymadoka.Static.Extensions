namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        public static bool IsSurrogatePair(this char highSurrogate, char lowSurrogate)
        {
            return char.IsSurrogatePair(highSurrogate, lowSurrogate);
        }
    }
}
