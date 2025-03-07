using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EccomerceApiCleanArchitecture.Service.Abstracts;
using EccomerceApiCleanArchitecture.Service.Implemtations;
using Microsoft.Extensions.DependencyInjection;
namespace EccomerceApiCleanArchitecture.Service
{
    public static class ModuleServiceDependencies
    {
        public static void AddServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            
        }
    }
}
