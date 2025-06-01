using System.Collections.Generic;
using System.Data;
using System.Dynamic;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 将 <see cref="DataRow"/> 转换为 <see cref="ExpandoObject"/>。
        /// </summary>
        /// <param name="this">要转换的 <see cref="DataRow"/> 实例。</param>
        /// <returns>包含所有列名和对应值的 <see cref="ExpandoObject"/>。</returns>
        public static dynamic ToExpandoObject(this DataRow @this)
        {
            dynamic entity = new ExpandoObject();
            var expandoDict = (IDictionary<string, object>)entity;

            foreach (DataColumn column in @this.Table.Columns)
            {
                expandoDict.Add(column.ColumnName, @this[column]);
            }

            return expandoDict;
        }
    }
}