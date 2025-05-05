using Aymadoka.Static.StringExtension;
using System.Text.Json;

namespace Aymadoka.Static.SerializeExtension
{
    public static partial class SerializeExtensions
    {
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
