using Aymadoka.Static.ObjectExtension;
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
        public static T GetValueToOrDefault<T>(this IDataReader @this, int index)
        {
            try
            {
                return @this.GetValue(index).To<T>();
            }
            catch
            {
                return default(T);
            }
        }

        public static T GetValueToOrDefault<T>(this IDataReader @this, int index, T defaultValue)
        {
            try
            {
                return @this.GetValue(index).To<T>();
            }
            catch
            {
                return defaultValue;
            }
        }

        public static T GetValueToOrDefault<T>(this IDataReader @this, int index, Func<IDataReader, int, T> defaultValueFactory)
        {
            try
            {
                return @this.GetValue(index).To<T>();
            }
            catch
            {
                return defaultValueFactory(@this, index);
            }
        }

        public static T GetValueToOrDefault<T>(this IDataReader @this, string columnName)
        {
            try
            {
                return @this.GetValue(@this.GetOrdinal(columnName)).To<T>();
            }
            catch
            {
                return default(T);
            }
        }

        public static T GetValueToOrDefault<T>(this IDataReader @this, string columnName, T defaultValue)
        {
            try
            {
                return @this.GetValue(@this.GetOrdinal(columnName)).To<T>();
            }
            catch
            {
                return defaultValue;
            }
        }

        public static T GetValueToOrDefault<T>(this IDataReader @this, string columnName, Func<IDataReader, string, T> defaultValueFactory)
        {
            try
            {
                return @this.GetValue(@this.GetOrdinal(columnName)).To<T>();
            }
            catch
            {
                return defaultValueFactory(@this, columnName);
            }
        }
    }
}
