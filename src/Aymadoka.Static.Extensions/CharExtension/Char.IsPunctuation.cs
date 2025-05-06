namespace Aymadoka.Static.CharExtension;

public static partial class CharExtensions
{
    public static bool IsPunctuation(this char c)
    {
        return char.IsPunctuation(c);
    }
}
