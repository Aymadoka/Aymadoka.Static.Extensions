using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aymadoka.Static.DataExtension;

public static partial class DataExtensions
{
    public static IEnumerable<dynamic> ExecuteExpandoObjects(this DbCommand @this)
    {
        using (IDataReader reader = @this.ExecuteReader())
        {
            return reader.ToExpandoObjects();
        }
    }
}
