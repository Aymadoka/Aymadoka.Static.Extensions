using System;
using System.Data;

namespace Aymadoka.Static.DataExtension
{

    public static partial class DataExtensions
    {
        /// <summary>
        /// 遍历 <see cref="IDataReader"/> 中的每一行，并对每一行执行指定的操作。
        /// </summary>
        /// <param name="this">要遍历的 <see cref="IDataReader"/> 实例。</param>
        /// <param name="action">对每一行执行的操作，参数为当前行的 <see cref="IDataReader"/>。</param>
        /// <returns>遍历完成后的 <see cref="IDataReader"/> 实例。</returns>
        public static IDataReader ForEach(this IDataReader @this, Action<IDataReader> action)
        {
            while (@this.Read())
            {
                action(@this);
            }

            return @this;
        }
    }
}