using System.Collections.Generic;
using System.Data;
using System.Dynamic;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 将 <see cref="DataTable"/> 转换为 <see cref="IEnumerable{dynamic}"/>，
        /// 每一行转换为 <see cref="ExpandoObject"/>，属性名为列名，属性值为对应单元格的值。
        /// </summary>
        /// <param name="this">要转换的 <see cref="DataTable"/> 实例。</param>
        /// <returns>包含所有行的动态对象集合。</returns>
        public static IEnumerable<dynamic> ToExpandoObjects(this DataTable @this)
        {
            var list = new List<dynamic>();

            foreach (DataRow dr in @this.Rows)
            {
                dynamic entity = new ExpandoObject();
                var expandoDict = (IDictionary<string, object>)entity;

                foreach (DataColumn column in @this.Columns)
                {
                    expandoDict.Add(column.ColumnName, dr[column]);
                }

                list.Add(entity);
            }

            return list;
        }
    }
}