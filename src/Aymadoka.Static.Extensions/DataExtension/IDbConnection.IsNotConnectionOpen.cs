using System.Data;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{

    public static partial class DataExtensions
    {
        public static bool IsNotConnectionOpen(this DbConnection @this)
        {
            return @this.State != ConnectionState.Open;
        }
    }
}