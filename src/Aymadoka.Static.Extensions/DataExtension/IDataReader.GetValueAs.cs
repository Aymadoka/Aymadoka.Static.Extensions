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
    public static T GetValueAs<T>(this IDataReader @this, int index)
    {
        return (T)@this.GetValue(index);
    }
    
    public static T GetValueAs<T>(this IDataReader @this, string columnName)
    {
        return (T)@this.GetValue(@this.GetOrdinal(columnName));
    }
}
