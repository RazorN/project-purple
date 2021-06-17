using Catalog.Domain.ProductAggregate;
using Catalog.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            var config = services.BuildServiceProvider().GetRequiredService<IConfiguration>();

            services.AddDbContext<CatalogContext>(options =>
                options.UseNpgsql(config.GetConnectionString("CatalogContext")));

            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
