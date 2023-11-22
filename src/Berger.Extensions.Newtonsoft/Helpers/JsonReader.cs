using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;

namespace Berger.Extensions.Newtonsoft
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
                try
                {
                    var json = File.ReadAllText(file);

                    if(!string.IsNullOrEmpty(json))
                    {
                        results.Add(JsonConvert.DeserializeObject<T>(json));
                    }                    
                }
                catch (global::System.Exception)
                {
                    throw;
                }
            }

            return results;
        }
    }
}