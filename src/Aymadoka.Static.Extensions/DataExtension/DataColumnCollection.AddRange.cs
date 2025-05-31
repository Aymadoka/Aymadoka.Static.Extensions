using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        public static void AddRange(this DataColumnCollection @this, params string[] columns)
        {
            foreach (string column in columns)
            {
                @this.Add(column);
            }
        }
    }
}