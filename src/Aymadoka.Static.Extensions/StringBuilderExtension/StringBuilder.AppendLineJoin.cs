using System;
using System.Collections.Generic;
using System.Text;

namespace Aymadoka.Static.StringBuilderExtension
{
    public static partial class StringBuilderExtensions
    {
        public static StringBuilder AppendLineJoin<T>(this StringBuilder @this, string separator, IEnumerable<T> values)
        {
            @this.AppendLine(string.Join(separator, values));

            return @this;
        }

        public static StringBuilder AppendLineJoin(this StringBuilder @this, string separator, params object[] values)
        {
            @this.AppendLine(string.Join(separator, values));

            return @this;
        }
    }
}
