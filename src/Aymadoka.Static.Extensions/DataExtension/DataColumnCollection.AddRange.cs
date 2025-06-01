using System.Data;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 向 <see cref="DataColumnCollection"/> 批量添加列名。
        /// </summary>
        /// <param name="this">要添加列的 <see cref="DataColumnCollection"/> 实例。</param>
        /// <param name="columns">要添加的列名数组。</param>
        public static void AddRange(this DataColumnCollection @this, params string[] columns)
        {
            foreach (string column in columns)
            {
                @this.Add(column);
            }
        }
    }
}