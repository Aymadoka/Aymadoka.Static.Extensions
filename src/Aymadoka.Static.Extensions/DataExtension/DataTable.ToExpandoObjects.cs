using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
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