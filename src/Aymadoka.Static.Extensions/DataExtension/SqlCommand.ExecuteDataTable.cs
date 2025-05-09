using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Reflection;

namespace Aymadoka.Static.DataExtension;

public static partial class DataExtensions
{
    public static DataTable ExecuteDataTable(this SqlCommand @this)
    {
        var dt = new DataTable();
        using (var dataAdapter = new SqlDataAdapter(@this))
        {
            dataAdapter.Fill(dt);
        }

        return dt;
    }
}
