using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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