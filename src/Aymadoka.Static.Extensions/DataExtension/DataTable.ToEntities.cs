using Aymadoka.Static.ObjectExtension;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 将 <see cref="DataTable"/> 转换为实体对象集合。
        /// </summary>
        /// <typeparam name="T">目标实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">要转换的 <see cref="DataTable"/> 实例。</param>
        /// <returns>实体对象集合。</returns>
        public static IEnumerable<T> ToEntities<T>(this DataTable @this) where T : new()
        {
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            var list = new List<T>();

            foreach (DataRow dr in @this.Rows)
            {
                var entity = new T();

                // 设置属性值
                foreach (PropertyInfo property in properties.Where(p => @this.Columns.Contains(p.Name)))
                {
                    Type valueType = property.PropertyType;
                    property.SetValue(entity, dr[property.Name].To(valueType), null);
                }

                // 设置字段值
                foreach (FieldInfo field in fields.Where(p => @this.Columns.Contains(p.Name)))
                {
                    Type valueType = field.FieldType;
                    field.SetValue(entity, dr[field.Name].To(valueType));
                }

                list.Add(entity);
            }

            return list;
        }
    }
}
