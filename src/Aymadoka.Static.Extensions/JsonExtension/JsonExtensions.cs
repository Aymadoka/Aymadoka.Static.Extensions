using Aymadoka.Static.StringExtension;
using System.Text.Json;

namespace Aymadoka.Static.JsonExtension
{
    public static class JsonExtensions
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

        /// <summary>将 JSON 字符串反序列化为对象</summary>
        /// <typeparam name="T">目标对象的类型</typeparam>
        /// <param name="json">JSON 字符串</param>
        /// <param name="options">可选的 JsonSerializerOptions</param>
        /// <returns>反序列化后的对象，如果 JSON 字符串为空或无效，则返回 null</returns>
        public static T? FromJson<T>(this string? json, JsonSerializerOptions? options = null) where T : class
        {
            if (json.IsNullOrWhiteSpace())
            {
                return null;
            }

            return JsonSerializer.Deserialize<T>(json, options ?? new JsonSerializerOptions());
        }
    }
}
