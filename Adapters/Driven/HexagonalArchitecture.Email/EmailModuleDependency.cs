using HexagonalArchitecture.Domain.Adapters;
using HexagonalArchitecture.Email.Operations;
using Microsoft.Extensions.DependencyInjection;

namespace HexagonalArchitecture.Email
{
    public static class EmailModuleDependency
    {
        public static void AddEmailModule(this IServiceCollection services)
        {
            services.AddTransient<IEmailAdapter, EmailManager>();
        }
    }
}
