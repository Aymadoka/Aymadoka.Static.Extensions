using System.Text.Json;

namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// 对对象进行深拷贝。
        /// </summary>
        /// <typeparam name="T">对象类型，必须为引用类型。</typeparam>
        /// <param name="this">要深拷贝的对象。</param>
        /// <returns>深拷贝后的新对象，如果源对象为 null，则返回 null。</returns>
        public static T? DeepClone<T>(this T? @this) where T : class
        {
            if (@this == null)
            {
                return null;
            }

            var options = new JsonSerializerOptions
            {
                WriteIndented = false,
            };

            var json = JsonSerializer.Serialize(@this, options);
            return JsonSerializer.Deserialize<T>(json, options)!;
        }
    }
}
