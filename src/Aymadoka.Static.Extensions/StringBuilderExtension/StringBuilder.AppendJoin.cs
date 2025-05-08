using System.Collections.Generic;
using System.Text;

namespace Aymadoka.Static.StringBuilderExtension;

public static partial class StringBuilderExtensions
{
    public static StringBuilder AppendJoin<T>(this StringBuilder @this, string separator, IEnumerable<T> values)
    {
        @this.Append(string.Join(separator, values));

        return @this;
    }

    public static StringBuilder AppendJoin<T>(this StringBuilder @this, string separator, params T[] values)
    {
        @this.Append(string.Join(separator, values));

        return @this;
    }
}
