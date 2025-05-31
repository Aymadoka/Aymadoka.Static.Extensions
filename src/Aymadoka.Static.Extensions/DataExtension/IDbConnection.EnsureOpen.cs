using System.Data;

namespace Aymadoka.Static.DataExtension
{

    public static partial class DataExtensions
    {
        public static void EnsureOpen(this IDbConnection @this)
        {
            if (@this.State == ConnectionState.Closed)
            {
                @this.Open();
            }
        }
    }
}