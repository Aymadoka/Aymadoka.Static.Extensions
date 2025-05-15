using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        /// <summary>
        /// 将对象数组转换为 DataTable
        /// </summary>
        /// <typeparam name="T">数组元素类型，必须包含公共属性和/或公共字段</typeparam>
        /// <param name="this">要转换的对象数组</param>
        /// <returns>
        /// 包含以下特征的 DataTable：
        /// <list type="bullet">
        ///   <item>列按类型中公共属性→公共字段的顺序创建</item>
        ///   <item>列名与属性/字段名称一致</item>
        ///   <item>列类型与属性/字段类型一致</item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// 注意：
        /// <list type="bullet">
        ///   <item>若数组元素为 null，将跳过该行的值填充</item>
        ///   <item>仅处理公共实例成员（不包含静态成员和私有成员）</item>
        /// </list>
        /// </remarks>
        public static DataTable ToDataTable<T>(this T[] @this)
        {
            Type type = typeof(T);

            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            var dt = new DataTable();

            foreach (PropertyInfo property in properties)
            {
                dt.Columns.Add(property.Name, property.PropertyType);
            }

            foreach (FieldInfo field in fields)
            {
                dt.Columns.Add(field.Name, field.FieldType);
            }

            foreach (T item in @this)
            {
                DataRow dr = dt.NewRow();

                foreach (PropertyInfo property in properties)
                {
                    dr[property.Name] = item == null ? DBNull.Value : property.GetValue(item, null);
                }

                foreach (FieldInfo field in fields)
                {
                    dr[field.Name] = item == null ? DBNull.Value : field.GetValue(item);
                }

                dt.Rows.Add(dr);
            }

            return dt;
        }
    }
}
