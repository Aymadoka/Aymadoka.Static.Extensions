using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.CharExtension;

public static partial class CharExtensions
{
    public static IEnumerable<char> To(this char @this, char toCharacter)
    {
        bool reverseRequired = (@this > toCharacter);

        char first = reverseRequired ? toCharacter : @this;
        char last = reverseRequired ? @this : toCharacter;

        IEnumerable<char> result = Enumerable.Range(first, last - first + 1).Select(charCode => (char)charCode);

        if (reverseRequired)
        {
            result = result.Reverse();
        }


        return result;
    }
}
