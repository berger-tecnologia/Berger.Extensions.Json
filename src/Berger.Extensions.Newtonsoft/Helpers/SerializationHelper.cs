using Newtonsoft.Json;

namespace Berger.Extensions.Newtonsoft
{
    public static class SerializationHelper
    {
        public static string Serialize(this object value, Formatting format = Formatting.Indented)
        {
            return JsonConvert.SerializeObject(value, format);
        }
        public static string Serialize(this string value, Formatting format = Formatting.Indented)
        {
            return JsonConvert.SerializeObject(value, format);
        }
        public static async Task<T> Deserialize<T>(this HttpResponseMessage response)
        {
            var content = await response.Content.ReadAsStringAsync();

            return Deserialize<T>(content);
        }
        public static T Deserialize<T>(this string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
        public static T Deserialize<T>(this string json, JsonSerializerSettings settings)
        {
            return JsonConvert.DeserializeObject<T>(json, settings);
        }
        public static object Deserialize(this string json)
        {
            return JsonConvert.DeserializeObject(json);
        }
        public static object Deserialize(this string json, JsonSerializerSettings settings)
        {
            return JsonConvert.DeserializeObject(json, settings);
        }
    }
}