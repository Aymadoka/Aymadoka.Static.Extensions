using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;

namespace Aymadoka.Static.DataExtension
{
    /// <summary>
    /// 提供 DataReader 的扩展方法。
    /// </summary>
    public static partial class DataExtensions
    {
        /// <summary>
        /// 将 <see cref="IDataReader"/> 的每一行转换为 <see cref="ExpandoObject"/>，并返回动态对象集合。
        /// </summary>
        /// <param name="this">要扩展的 <see cref="IDataReader"/> 实例。</param>
        /// <returns>包含每行数据的动态对象集合。</returns>
        public static IEnumerable<dynamic> ToExpandoObjects(this IDataReader @this)
        {
            // 获取所有列的索引和列名
            Dictionary<int, KeyValuePair<int, string>> columnNames = Enumerable.Range(0, @this.FieldCount)
                .Select(x => new KeyValuePair<int, string>(x, @this.GetName(x)))
                .ToDictionary(pair => pair.Key);

            var list = new List<dynamic>();

            // 逐行读取数据
            while (@this.Read())
            {
                dynamic entity = new ExpandoObject();
                var expandoDict = (IDictionary<string, object>)entity;

                // 将每一列的数据添加到动态对象中
                Enumerable.Range(0, @this.FieldCount)
                    .ToList()
                    .ForEach(x => expandoDict.Add(columnNames[x].Value, @this[x]));

                list.Add(entity);
            }

            return list;
        }
    }
}