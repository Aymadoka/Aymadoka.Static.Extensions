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
    public static DataRow LastRow(this DataTable @this)
    {
        return @this.Rows[@this.Rows.Count - 1];
    }
}
