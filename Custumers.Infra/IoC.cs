using Custumers.Infra.Persistence.Repositories;
using Custumers.Infra.Persistence.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Custumers.Infra
{
    public static class IoC
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
               .AddScoped<ICostumerRepository, CostumerRepository>();
        }
    }
}
