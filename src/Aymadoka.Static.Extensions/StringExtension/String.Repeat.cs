using System.Text;

namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static string Repeat(this string @this, int repeatCount)
    {
        if (@this.Length == 1)
        {
            return new string(@this[0], repeatCount);
        }

        var sb = new StringBuilder(repeatCount * @this.Length);
        while (repeatCount-- > 0)
        {
            sb.Append(@this);
        }

        return sb.ToString();
    }
}
