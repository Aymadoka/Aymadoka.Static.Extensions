using System;
using System.Text;

namespace Aymadoka.Static.StringBuilderExtension;

public static partial class StringBuilderExtensions
{
    public static StringBuilder AppendIf<T>(this StringBuilder @this, Func<T, bool> predicate, params T[] values)
    {
        foreach (var value in values)
        {
            if (predicate(value))
            {
                @this.Append(value);
            }
        }

        return @this;
    }
}
