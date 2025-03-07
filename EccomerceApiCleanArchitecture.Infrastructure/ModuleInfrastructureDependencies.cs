using EccomerceApiCleanArchitecture.Infrastructure.Abstracts;
using EccomerceApiCleanArchitecture.Infrastructure.InfrastructureBase;
using EccomerceApiCleanArchitecture.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static void AddInfastuctureDependencies(this IServiceCollection services) { 
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>(); 
            services.AddScoped(typeof (IGenericRepositoryAsync<>),typeof( GenericRepositoryAsync<>));


        }
    }
}
