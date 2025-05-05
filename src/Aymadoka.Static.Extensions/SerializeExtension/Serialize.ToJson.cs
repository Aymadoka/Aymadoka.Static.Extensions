using System.Text.Json;

namespace Aymadoka.Static.SerializeExtension
{
    public static partial class SerializeExtensions
    {
        /// <summary>将对象序列化为 JSON 字符串</summary>
        /// <typeparam name="T">对象的类型</typeparam>
        /// <param name="data">要序列化的对象</param>
        /// <param name="options">可选的 JsonSerializerOptions</param>
        /// <returns>JSON 字符串，如果对象为 null，则返回 null</returns>
        public static string? ToJson<T>(this T? data, JsonSerializerOptions? options = null) where T : class
        {
            if (data == null)
            {
                return null;
            }

            return JsonSerializer.Serialize(data, options ?? new JsonSerializerOptions());
        }
    }
}
