using Custumers.Infra.Persistence.Repositories.Interfaces;
using Custumers.Infra.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Custumers.Application.Intefaces;
using Custumers.Application.Services;

namespace Custumers.Application
{
    public static class IoC
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
               .AddScoped<ICostumerService, CostumerService>();
        }
    }
}
