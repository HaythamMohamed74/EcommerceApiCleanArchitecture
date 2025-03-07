using EccomerceApiCleanArchitecture.Core.Behaviors;
using EccomerceApiCleanArchitecture.Service.Abstracts;
using EccomerceApiCleanArchitecture.Service.Implemtations;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

//using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Core
{
    public static class ModuleCoreDependencies
    {
        public static void  AddCoreDependencies(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestBehavior<,>));
        }

    }
}
