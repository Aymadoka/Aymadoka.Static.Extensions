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
        /// 将 <see cref="IDataReader"/> 当前行的数据映射为类型 <typeparamref name="T"/> 的新实例。
        /// 属性和字段名称需与数据源列名一致，支持公共属性和字段。
        /// </summary>
        /// <typeparam name="T">目标实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">数据读取器，指向当前行。</param>
        /// <returns>类型为 <typeparamref name="T"/> 的实体对象。</returns>
        public static T ToEntity<T>(this IDataReader @this) where T : new()
        {
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            var entity = new T();

            // 获取所有列名，便于后续匹配属性和字段
            var hash = new HashSet<string>(Enumerable.Range(0, @this.FieldCount)
                .Select(@this.GetName));

            // 映射属性
            foreach (PropertyInfo property in properties.Where(p => hash.Contains(p.Name)))
            {
                Type valueType = property.PropertyType;
                property.SetValue(entity, @this[property.Name].To(valueType), null);
            }

            // 映射字段
            foreach (FieldInfo field in fields.Where(p => hash.Contains(p.Name)))
            {
                Type valueType = field.FieldType;
                field.SetValue(entity, @this[field.Name].To(valueType));
            }

            return entity;
        }
    }
}