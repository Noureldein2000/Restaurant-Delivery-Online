using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RDO.Domain;
using RDO.Services.Repositories;
using RDO.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDO.API.Utils
{
    public static class ServicesExtention
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(ApplicationDbContext));
            services.AddScoped(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IMenuService, MenuService>();
            services.AddScoped<IRestaurantService, RestaurantService>();
        }
    }
}
