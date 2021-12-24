using HexagonalArchitecture.Domain.Adapters;
using HexagonalArchitecture.ExternalApis.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HexagonalArchitecture.ExternalApis
{
    public static class ExternalApisModuleDependency
    {
        public static void AddExternalApisModule(this IServiceCollection services)
        {
            services.AddTransient<ICorreiosAdapter, CorreiosService>();
        }
    }
}
