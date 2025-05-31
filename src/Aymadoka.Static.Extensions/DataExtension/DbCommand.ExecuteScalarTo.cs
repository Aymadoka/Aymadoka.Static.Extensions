using Aymadoka.Static.ObjectExtension;
using System.Data.Common;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        public static T ExecuteScalarTo<T>(this DbCommand @this)
        {
            return @this.ExecuteScalar().To<T>();
        }
    }
}