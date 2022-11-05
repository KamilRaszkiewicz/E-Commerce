using E_Commerce.App.Interfaces;
using E_Commerce.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(
                o => o.UseSqlServer(config["ConnectionStrings:DefaultConnectionString"],
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)), ServiceLifetime.Transient
            );
            services.AddScoped<IApplicationDbContext>(p => p.GetService<ApplicationDbContext>());
            return services;
        }
    }
}
