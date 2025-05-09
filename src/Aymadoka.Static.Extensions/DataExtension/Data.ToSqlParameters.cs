using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.DataExtension;

public static partial class DataExtensions
{
    public static SqlParameter[] ToSqlParameters(this IDictionary<string, object> @this)
    {
        return @this.Select(x => new SqlParameter(x.Key, x.Value)).ToArray();
    }
}
