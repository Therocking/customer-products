using Microsoft.Extensions.DependencyInjection;
using Products.Infra.Persistence.Repositories.Interfaces;
using Products.Infra.Persistence.Repositories;
using Proyects.App.Interfaces;
using Proyects.App.Services;

namespace Proyects.App
{
    public static class IoC
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
               .AddScoped<IProductsService, ProductsServices>();
        }
    }
}
