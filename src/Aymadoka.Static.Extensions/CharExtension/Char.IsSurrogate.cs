namespace Aymadoka.Static.CharExtension;

public static partial class CharExtensions
{
    public static bool IsSurrogate(this char c)
    {
        return char.IsSurrogate(c);
    }
}
