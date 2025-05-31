using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Aymadoka.Static.DataExtension
{

    public static partial class DataExtensions
    {
        public static IEnumerable<string> GetColumnNames(this IDataRecord @this)
        {
            return Enumerable.Range(0, @this.FieldCount)
                .Select(@this.GetName)
                .ToList();
        }
    }
}