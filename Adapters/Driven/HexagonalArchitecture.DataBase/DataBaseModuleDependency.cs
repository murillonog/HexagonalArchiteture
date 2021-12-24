using HexagonalArchitecture.DataBase.Repositories;
using HexagonalArchitecture.Domain.Adapters;
using Microsoft.Extensions.DependencyInjection;

namespace HexagonalArchitecture.DataBase
{
    public static class DataBaseModuleDependency
    {
        public static void AddDataBaseModule(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
        }
    }
}
