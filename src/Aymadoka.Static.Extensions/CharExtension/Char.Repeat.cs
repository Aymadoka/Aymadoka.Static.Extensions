namespace Aymadoka.Static.CharExtension;

public static partial class CharExtensions
{
    public static string Repeat(this char @this, int repeatCount)
    {
        return new string(@this, repeatCount);
    }
}
