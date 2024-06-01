using ePizzaDelivery.Entities;
using ePizzaDelivery.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizzaDelivery.Services.Configurations
{
    public static class ConfigureRepositories
    {
        public static IServiceCollection AddRepositoryServices(this IServiceCollection services,IConfiguration configuration)
        {
            // Register your interfaces and implementations here
            services.AddDbContext<AppDbContext>((options) =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DbConnection"));
            });
            services.AddIdentity<User, Role>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
            services.AddScoped<DbContext, AppDbContext>();
            return services;
        }
    }
}
