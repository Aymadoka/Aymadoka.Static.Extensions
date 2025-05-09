using Microsoft.Data.SqlClient;
using System;
using System.Reflection;

namespace Aymadoka.Static.DataExtension;

public static partial class DataExtensions
{
    public static SqlConnection GetConnection(this SqlBulkCopy @this)
    {
        Type type = @this.GetType();
        FieldInfo field = type.GetField("_connection", BindingFlags.NonPublic | BindingFlags.Instance);
        return field.GetValue(@this) as SqlConnection;
    }
}
