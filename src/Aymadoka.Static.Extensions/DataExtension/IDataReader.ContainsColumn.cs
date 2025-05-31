using System;
using System.Data;

namespace Aymadoka.Static.DataExtension
{

    public static partial class DataExtensions
    {
        public static bool ContainsColumn(this IDataReader @this, int columnIndex)
        {
            try
            {
                // Check if FieldCount is implemented first
                return @this.FieldCount > columnIndex;
            }
            catch (Exception)
            {
                try
                {
                    return @this[columnIndex] != null;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public static bool ContainsColumn(this IDataReader @this, string columnName)
        {
            try
            {
                // Check if GetOrdinal is implemented first
                return @this.GetOrdinal(columnName) != -1;
            }
            catch (Exception)
            {
                try
                {
                    return @this[columnName] != null;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}