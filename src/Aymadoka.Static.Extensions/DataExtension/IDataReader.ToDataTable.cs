using System.Data;

namespace Aymadoka.Static.DataExtension
{

    public static partial class DataExtensions
    {
        public static DataTable ToDataTable(this IDataReader @this)
        {
            var dt = new DataTable();
            dt.Load(@this);
            return dt;
        }
    }
}