using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Berger.Extensions.Newtonsoft
{
    public static class JsonHelper
    {
        public static void ConfigureLoopHandling()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };
        }
        public static void ConfigureFormatting(Formatting format)
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                Formatting = format
            };
        }
        public static void ConfigureDateFormat(string format)
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                DateFormatString = format
            };
        }
        public static void ConfigureContract(string format)
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver()
            };
        }
    }
}