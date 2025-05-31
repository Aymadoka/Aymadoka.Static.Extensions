using Microsoft.Data.SqlClient;
using System.Data;

namespace Aymadoka.Static.DataExtension
{

    public static partial class DataExtensions
    {
        public static DataSet ExecuteDataSet(this SqlCommand @this)
        {
            var ds = new DataSet();
            using (var dataAdapter = new SqlDataAdapter(@this))
            {
                dataAdapter.Fill(ds);
            }

            return ds;
        }
    }
}