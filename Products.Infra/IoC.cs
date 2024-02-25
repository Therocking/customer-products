using Microsoft.Extensions.DependencyInjection;
using Products.Infra.Persistence.Repositories;
using Products.Infra.Persistence.Repositories.Interfaces;

namespace Products.Infra
{
    public static class IoC
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
               .AddScoped<IProductsRepository, ProductsRepository>();
        }
    }
}
