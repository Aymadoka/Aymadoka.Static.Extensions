using Aymadoka.Static.ObjectExtension;
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
    public static T ExecuteScalarTo<T>(this DbCommand @this)
    {
        return @this.ExecuteScalar().To<T>();
    }
}
