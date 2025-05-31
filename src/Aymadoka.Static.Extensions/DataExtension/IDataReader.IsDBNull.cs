using System.Data;

namespace Aymadoka.Static.DataExtension
{

    public static partial class DataExtensions
    {
        public static bool IsDBNull(this IDataReader @this, string name)
        {
            return @this.IsDBNull(@this.GetOrdinal(name));
        }
    }
}