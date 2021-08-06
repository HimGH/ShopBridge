using Microsoft.Extensions.DependencyInjection;
using ShopBridge.Data;
using ShopBridge.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.API
{

    public static class RepositoryMapperConfiguration
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IProductLogic, ProductLogic>();
            services.AddScoped<IProductTypeRepository, ProductTypeRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
