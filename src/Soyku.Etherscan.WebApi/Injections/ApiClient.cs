using Microsoft.Extensions.DependencyInjection;
using Soyku.Etherscan.Core.ClientFactory;

namespace Soyku.Etherscan.WebApi.Injections
{
    public static class ApiClientInjection
    {
        public static IServiceCollection AddApiClient(this IServiceCollection services)
        {
            services.AddScoped<IApiClient, ApiClient>();

            return services;
        }
    }
}
