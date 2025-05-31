using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        public static T ExecuteScalarAs<T>(this DbCommand @this)
        {
            return (T)@this.ExecuteScalar();
        }
    }
}