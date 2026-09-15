using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.Extensions.DependencyInjection;
using StocksApp.Core;
using StocksApp.Server.AppDbContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace StocksApp.Test.IntegrationTests
{
    public class CustomWebApplicationFactory : WebApplicationFactory<Program>
    {

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            base.ConfigureWebHost(builder);

            builder.UseEnvironment("Test");
            builder.ConfigureServices(services =>
            {
                // 1. Remove the existing DbContext registration
                var descriptor = services.SingleOrDefault(temp => 
                temp.ServiceType == typeof(DbContextOptions<StockMarketDbContext>));

                if(descriptor is not null)
                {
                    services.Remove(descriptor);
                }

                // 2. CRITICAL FOR EF CORE 9+: Remove the underlying configuration tracker
                var configDescriptor = services.SingleOrDefault(temp =>
                temp.ServiceType == typeof(IDbContextOptionsConfiguration<StockMarketDbContext>));

                if(configDescriptor is not null)
                    services.Remove(configDescriptor);

                services.AddDbContext<StockMarketDbContext>(options =>
                {
                    options.UseInMemoryDatabase("DatabaseForTesting");
                });
            });
            

        }

    }
}
