using System;
using System.Data;

namespace Aymadoka.Static.DataExtension
{

    public static partial class DataExtensions
    {
        public static IDataReader ForEach(this IDataReader @this, Action<IDataReader> action)
        {
            while (@this.Read())
            {
                action(@this);
            }

            return @this;
        }
    }
}