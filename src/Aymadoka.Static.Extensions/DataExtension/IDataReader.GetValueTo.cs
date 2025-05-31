using Aymadoka.Static.ObjectExtension;
using System.Data;

namespace Aymadoka.Static.DataExtension
{

    public static partial class DataExtensions
    {
        public static T GetValueTo<T>(this IDataReader @this, int index)
        {
            return @this.GetValue(index).To<T>();
        }

        public static T GetValueTo<T>(this IDataReader @this, string columnName)
        {
            return @this.GetValue(@this.GetOrdinal(columnName)).To<T>();
        }
    }
}