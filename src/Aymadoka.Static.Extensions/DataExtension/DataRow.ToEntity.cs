using Aymadoka.Static.ObjectExtension;
using System;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Aymadoka.Static.DataExtension
{
    public static partial class DataExtensions
    {
        /// <summary>
        /// 将 <see cref="DataRow"/> 转换为指定类型的实体对象。
        /// </summary>
        /// <typeparam name="T">目标实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">要转换的 <see cref="DataRow"/> 实例。</param>
        /// <returns>转换后的实体对象。</returns>
        public static T ToEntity<T>(this DataRow @this) where T : new()
        {
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            var entity = new T();

            // 设置属性值
            foreach (PropertyInfo property in properties.Where(p => @this.Table.Columns.Contains(p.Name)))
            {
                Type valueType = property.PropertyType;
                property.SetValue(entity, @this[property.Name].To(valueType), null);
            }

            // 设置字段值
            foreach (FieldInfo field in fields.Where(p => @this.Table.Columns.Contains(p.Name)))
            {
                Type valueType = field.FieldType;
                field.SetValue(entity, @this[field.Name].To(valueType));
            }

            return entity;
        }
    }
}