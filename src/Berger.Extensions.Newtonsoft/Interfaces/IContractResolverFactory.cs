using Newtonsoft.Json.Serialization;

namespace Berger.Extensions.Newtonsoft
{
    public interface IContractResolverFactory
    {
        IContractResolver GetResolver(string identifier);
    }
}