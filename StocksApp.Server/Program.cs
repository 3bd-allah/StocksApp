using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using QuestPDF.Infrastructure;
using StocksApp.Server.AppDbContext;
using StocksApp.Server.IRepository;
using StocksApp.Server.Options;
using StocksApp.Server.Repository;
using StocksApp.Server.Services;
using StocksApp.Server.Services.Contracts;

namespace StocksApp.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            QuestPDF.Settings.License = LicenseType.Community;
            builder.Services.AddControllers();
            builder.Services.AddScoped<IFinnhubService, FinnhubService>();
            builder.Services.AddScoped<IStockService, StockService>();
            builder.Services.AddScoped<IStockRepository, StockRepository>();
            builder.Services.AddScoped<IOrdersPdfGenerator, OrdersPdfGenerator>();
            builder.Services.Configure<TradingOptions>(builder.Configuration.GetSection("TradingOptions"));
            
            builder.Services.AddHttpClient();
            builder.Services.AddDbContext<StockMarketDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
                options.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
            });
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy.AllowAnyOrigin();
                    policy.AllowAnyHeader();
                    policy.AllowAnyMethod();
                });
            });

            var app = builder.Build();

          
            app.UseStaticFiles();
            // Configure the HTTP request pipeline.
            app.UseRouting();
            app.UseCors();

            app.MapControllers();

            

            app.Run();
        }
    }
}

//public partial class Program { }
