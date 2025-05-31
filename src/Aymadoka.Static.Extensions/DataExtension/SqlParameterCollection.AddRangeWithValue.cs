using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace Aymadoka.Static.DataExtension
{

    public static partial class DataExtensions
    {
        public static void AddRangeWithValue(this SqlParameterCollection @this, Dictionary<string, object> values)
        {
            foreach (var keyValuePair in values)
            {
                @this.AddWithValue(keyValuePair.Key, keyValuePair.Value);
            }
        }
    }
}