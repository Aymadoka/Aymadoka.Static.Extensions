using System.Collections.Generic;
using System.Text;

namespace Aymadoka.Static.StringBuilderExtension
{
    public static partial class StringBuilderExtensions
    {
        public static StringBuilder AppendLineFormat(this StringBuilder @this, string format, params object[] args)
        {
            @this.AppendLine(string.Format(format, args));

            return @this;
        }

        public static StringBuilder AppendLineFormat(this StringBuilder @this, string format, List<IEnumerable<object>> args)
        {
            @this.AppendLine(string.Format(format, args));

            return @this;
        }
    }
}
