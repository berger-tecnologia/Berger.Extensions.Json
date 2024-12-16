using Newtonsoft.Json.Serialization;
using Microsoft.Extensions.DependencyInjection;

namespace Berger.Extensions.Newtonsoft
{
    public class ContractResolverFactory : IContractResolverFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public ContractResolverFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IContractResolver GetResolver<T>()
        {
            var resolver = _serviceProvider.GetService<IContractResolver<T>>();

            if (resolver == null)
            {
                throw new InvalidOperationException($"No resolver registered for type {typeof(T).Name}");
            }

            return resolver;
        }
    }
}