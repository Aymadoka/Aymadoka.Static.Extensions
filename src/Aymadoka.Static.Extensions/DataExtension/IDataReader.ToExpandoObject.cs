using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 将 <see cref="IDataReader"/> 当前行的数据转换为 <see cref="ExpandoObject"/>。
        /// 每一列的列名作为动态对象的属性名，列值作为属性值。
        /// </summary>
        /// <param name="this">要转换的 <see cref="IDataReader"/> 实例。</param>
        /// <returns>包含当前行所有列的动态对象。</returns>
        public static dynamic ToExpandoObject(this IDataReader @this)
        {
            // 获取所有列的索引和列名
            Dictionary<int, KeyValuePair<int, string>> columnNames = Enumerable.Range(0, @this.FieldCount)
                .Select(x => new KeyValuePair<int, string>(x, @this.GetName(x)))
                .ToDictionary(pair => pair.Key);

            // 创建动态对象
            dynamic entity = new ExpandoObject();
            var expandoDict = (IDictionary<string, object>)entity;

            // 将每一列的数据添加到动态对象中
            Enumerable.Range(0, @this.FieldCount)
                .ToList()
                .ForEach(x => expandoDict.Add(columnNames[x].Value, @this[x]));

            return entity;
        }
    }
}