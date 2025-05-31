using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        public static DataRow FirstRow(this DataTable @this)
        {
            return @this.Rows[0];
        }
    }
}