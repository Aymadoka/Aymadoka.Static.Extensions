using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aymadoka.Static.DataExtension;

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
