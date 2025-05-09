using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aymadoka.Static.DataExtension;

public static partial class DataExtensions
{
    public static dynamic ToExpandoObject(this IDataReader @this)
    {
        Dictionary<int, KeyValuePair<int, string>> columnNames = Enumerable.Range(0, @this.FieldCount)
            .Select(x => new KeyValuePair<int, string>(x, @this.GetName(x)))
            .ToDictionary(pair => pair.Key);

        dynamic entity = new ExpandoObject();
        var expandoDict = (IDictionary<string, object>)entity;

        Enumerable.Range(0, @this.FieldCount)
            .ToList()
            .ForEach(x => expandoDict.Add(columnNames[x].Value, @this[x]));

        return entity;
    }
}
