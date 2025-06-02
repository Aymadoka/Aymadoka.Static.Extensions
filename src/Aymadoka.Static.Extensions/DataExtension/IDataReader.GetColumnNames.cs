using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Aymadoka.Static.DataExtension
{

    public static partial class DataExtensions
    {
        /// <summary>
        /// 获取 <see cref="IDataRecord"/> 的所有列名。
        /// </summary>
        /// <param name="this">要获取列名的 <see cref="IDataRecord"/> 实例。</param>
        /// <returns>包含所有列名的字符串集合。</returns>
        public static IEnumerable<string> GetColumnNames(this IDataRecord @this)
        {
            return Enumerable.Range(0, @this.FieldCount)
                .Select(@this.GetName)
                .ToList();
        }
    }
}