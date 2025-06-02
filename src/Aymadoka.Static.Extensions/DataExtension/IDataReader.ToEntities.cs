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
        /// 将 <see cref="IDataReader"/> 中的数据转换为指定类型 <typeparamref name="T"/> 的实体集合。
        /// </summary>
        /// <typeparam name="T">目标实体类型，必须有无参构造函数。</typeparam>
        /// <param name="this">数据读取器实例。</param>
        /// <returns>类型为 <typeparamref name="T"/> 的实体集合。</returns>
        public static IEnumerable<T> ToEntities<T>(this IDataReader @this) where T : new()
        {
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            var list = new List<T>();

            // 获取数据读取器中的所有字段名，便于后续匹配实体属性或字段
            var hash = new HashSet<string>(Enumerable.Range(0, @this.FieldCount)
                .Select(@this.GetName));

            while (@this.Read())
            {
                var entity = new T();

                // 将数据读取器中的值赋给实体的属性
                foreach (PropertyInfo property in properties.Where(p => hash.Contains(p.Name)))
                {
                    Type valueType = property.PropertyType;
                    property.SetValue(entity, @this[property.Name].To(valueType), null);
                }

                // 将数据读取器中的值赋给实体的字段
                foreach (FieldInfo field in fields.Where(p => hash.Contains(p.Name)))
                {
                    Type valueType = field.FieldType;
                    field.SetValue(entity, @this[field.Name].To(valueType));
                }

                list.Add(entity);
            }

            return list;
        }
    }
}