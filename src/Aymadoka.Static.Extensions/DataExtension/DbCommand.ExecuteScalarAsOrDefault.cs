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
    public static T ExecuteScalarAsOrDefault<T>(this DbCommand @this)
    {
        try
        {
            return (T)@this.ExecuteScalar();
        }
        catch (Exception)
        {
            return default(T);
        }
    }

    public static T ExecuteScalarAsOrDefault<T>(this DbCommand @this, T defaultValue)
    {
        try
        {
            return (T)@this.ExecuteScalar();
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    public static T ExecuteScalarAsOrDefault<T>(this DbCommand @this, Func<DbCommand, T> defaultValueFactory)
    {
        try
        {
            return (T)@this.ExecuteScalar();
        }
        catch (Exception)
        {
            return defaultValueFactory(@this);
        }
    }
}
