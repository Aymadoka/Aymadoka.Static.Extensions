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
    public static T GetValueAsOrDefault<T>(this IDataReader @this, int index)
    {
        try
        {
            return (T)@this.GetValue(index);
        }
        catch
        {
            return default(T);
        }
    }

    public static T GetValueAsOrDefault<T>(this IDataReader @this, int index, T defaultValue)
    {
        try
        {
            return (T)@this.GetValue(index);
        }
        catch
        {
            return defaultValue;
        }
    }

    public static T GetValueAsOrDefault<T>(this IDataReader @this, int index, Func<IDataReader, int, T> defaultValueFactory)
    {
        try
        {
            return (T)@this.GetValue(index);
        }
        catch
        {
            return defaultValueFactory(@this, index);
        }
    }

    public static T GetValueAsOrDefault<T>(this IDataReader @this, string columnName)
    {
        try
        {
            return (T)@this.GetValue(@this.GetOrdinal(columnName));
        }
        catch
        {
            return default(T);
        }
    }

    public static T GetValueAsOrDefault<T>(this IDataReader @this, string columnName, T defaultValue)
    {
        try
        {
            return (T)@this.GetValue(@this.GetOrdinal(columnName));
        }
        catch
        {
            return defaultValue;
        }
    }

    public static T GetValueAsOrDefault<T>(this IDataReader @this, string columnName, Func<IDataReader, string, T> defaultValueFactory)
    {
        try
        {
            return (T)@this.GetValue(@this.GetOrdinal(columnName));
        }
        catch
        {
            return defaultValueFactory(@this, columnName);
        }
    }
}
