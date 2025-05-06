namespace Aymadoka.Static.CharExtension;

public static partial class CharExtensions
{
    public static int ConvertToUtf32(this char highSurrogate, char lowSurrogate)
    {
        return char.ConvertToUtf32(highSurrogate, lowSurrogate);
    }
}
