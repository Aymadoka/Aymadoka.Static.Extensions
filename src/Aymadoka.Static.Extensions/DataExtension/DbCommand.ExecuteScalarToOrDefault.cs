using Aymadoka.Static.ObjectExtension;
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
    public static T ExecuteScalarToOrDefault<T>(this DbCommand @this)
    {
        try
        {
            return @this.ExecuteScalar().To<T>();
        }
        catch (Exception)
        {
            return default(T);
        }
    }

    public static T ExecuteScalarToOrDefault<T>(this DbCommand @this, T defaultValue)
    {
        try
        {
            return @this.ExecuteScalar().To<T>();
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    public static T ExecuteScalarToOrDefault<T>(this DbCommand @this, Func<DbCommand, T> defaultValueFactory)
    {
        try
        {
            return @this.ExecuteScalar().To<T>();
        }
        catch (Exception)
        {
            return defaultValueFactory(@this);
        }
    }
}
