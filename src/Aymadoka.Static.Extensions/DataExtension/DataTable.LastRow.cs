using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        public static DataRow LastRow(this DataTable @this)
        {
            return @this.Rows[@this.Rows.Count - 1];
        }
    }
}