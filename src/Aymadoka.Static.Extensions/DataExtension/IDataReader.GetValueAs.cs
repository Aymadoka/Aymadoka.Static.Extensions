using System.Data;

namespace Aymadoka.Static.DataExtension
{

    public static partial class DataExtensions
    {
        public static T GetValueAs<T>(this IDataReader @this, int index)
        {
            return (T)@this.GetValue(index);
        }

        public static T GetValueAs<T>(this IDataReader @this, string columnName)
        {
            return (T)@this.GetValue(@this.GetOrdinal(columnName));
        }
    }
}