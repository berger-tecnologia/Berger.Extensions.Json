using Newtonsoft.Json;

namespace Berger.Extensions.Newtonsoft
{
    public static class SerializationHelper
    {
        public static string Serialize(this object value)
        {
            return JsonConvert.SerializeObject(value, Formatting.Indented);
        }
        public static string Serialize(this string value)
        {
            return JsonConvert.SerializeObject(value, Formatting.Indented);
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
        public static object Deserialize(this string json)
        {
            return JsonConvert.DeserializeObject(json);
        }
    }
}