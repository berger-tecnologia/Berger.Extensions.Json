using Newtonsoft.Json;

namespace Berger.Extensions.Json
{
    public static class JsonReader
    {
        public static T Read<T>(string file)
        {
            string json = File.ReadAllText(file);

            return JsonConvert.DeserializeObject<T>(json);
        }

        public static List<T> Read<T>(string[] files)
        {
            var results = new List<T>();

            foreach (var file in files)
            {
                var json = File.ReadAllText(file);

                results.Add(JsonConvert.DeserializeObject<T>(json));
            }

            return results;
        }
    }
}